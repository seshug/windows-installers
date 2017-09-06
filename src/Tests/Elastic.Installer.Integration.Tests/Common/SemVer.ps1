﻿<#
Powershell script port of SemVer from https://gist.github.com/jageall/c5119d5ba26fa33602d1
of https://github.com/maxhauser/semver

Copyright (c) 2013 Max Hauser 

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
#>

function ConvertTo-SemanticVersion($version){
    $version -match "^(?<major>\d+)(\.(?<minor>\d+))?(\.(?<patch>\d+))?(\-(?<pre>[0-9A-Za-z\-\.]+))?(\+(?<build>[0-9A-Za-z\-\.]+))?$" | Out-Null
    $major = [int]$matches['major']
    $minor = [int]$matches['minor']
    $patch = [int]$matches['patch']
    
    if($matches['pre'] -eq $null){$pre = @()}
    else{$pre = $matches['pre'].Split(".")}

    New-Object PSObject -Property @{ 
        Major = $major
        Minor = $minor
        Patch = $patch
        Pre = $pre
        VersionString = $version
    }
}

function Compare-SemanticVersion($a, $b){
    $result = 0
    $result =  $a.Major.CompareTo($b.Major)
    if($result -ne 0){return $result}

    $result = $a.Minor.CompareTo($b.Minor)
    if($result -ne 0){return $result}

    $result = $a.Patch.CompareTo($b.Patch)
    if($result -ne 0){return $result}
    $ap = $a.Pre
    $bp = $b.Pre
    if($ap.Length  -eq 0 -and $bp.Length -eq 0) {return 0}
    if($ap.Length  -eq 0){return 1}
    if($bp.Length  -eq 0){return -1}
    
    $minLength = [Math]::Min($ap.Length, $bp.Length)
    for($i = 0; $i -lt $minLength; $i++){
        $ac = $ap[$i]
        $bc = $bp[$i]

        $anum = 0 
        $bnum = 0
        $aIsNum = [Int]::TryParse($ac, [ref] $anum)
        $bIsNum = [Int]::TryParse($bc, [ref] $bnum)

        if($aIsNum -and $bIsNum) { 
            # Write-Host "2" $a.VersionString $b.VersionString $anum $bnum $anum.CompareTo($bnum)
            $result = $anum.CompareTo($bnum) 
            if($result -ne 0)
            {
                return $result
            }
        }
        if($aIsNum) {
            # Write-Host "3" $a.VersionString $b.VersionString
            return -1
        }
        if($bIsNum) {
           # Write-Host "4" $a.VersionString $b.VersionString $bIsNum $aIsNum $ac $bc $ap.Length $bp.Length $i
        return 1}
        
        $result = [string]::CompareOrdinal($ac, $bc)
        if($result -ne 0) {
        
        return $result
        }
    }
    # Write-Host "comparing lengths" $ap.Length $bp.Length $ap.Length.CompareTo($bp.Length) $a.VersionString $b.VersionString
    return $ap.Length.CompareTo($bp.Length)
}

function Add-RankToSemanticVersion($versions){
    for($i = 0; $i -lt $versions.Length; $i++){
        $rank = 0
        for($j = 0; $j -lt $versions.Length; $j++){
            $diff = 0
            $diff = compareSemVer $versions[$i] $versions[$j]
            if($diff -gt 0) {
                # Write-Host $versions[$i].VersionString "is greater than " $versions[$j].VersionString " got diff " $diff
                $rank++
            }
        }
        $current = [PsObject]$versions[$i]
        Add-Member -InputObject $current -MemberType NoteProperty -Name Rank -Value $rank
    }
    return $versions
}