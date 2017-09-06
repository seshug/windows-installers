using System;
using System.IO.Abstractions;
using Elastic.Installer.Domain.Configuration.Service;
using Elastic.Installer.Domain.Configuration.Wix.Session;
using Elastic.Installer.Domain.Model.Elasticsearch;

namespace Elastic.InstallerHosts.Elasticsearch.Tasks
{
	public class EnsureServiceStartTask : ElasticsearchInstallationTask
	{
		private IServiceStateProvider ServiceStateProvider { get; }

		public EnsureServiceStartTask(string[] args, ISession session) : base(args, session)
		{
			this.ServiceStateProvider = new ServiceStateProvider(session, "Elasticsearch");
		}

		public EnsureServiceStartTask(ElasticsearchInstallationModel model, ISession session, IFileSystem fileSystem, IServiceStateProvider serviceConfig) 
			: base(model, session, fileSystem)
		{
			this.ServiceStateProvider = serviceConfig;
		}

		protected override bool ExecuteTask()
		{
			this.Session.Log($"Existing Version Installed: {this.InstallationModel.NoticeModel.ExistingVersionInstalled}");
			this.Session.Log($"Current Version: {this.InstallationModel.NoticeModel.CurrentVersion}");
			this.Session.Log($"Existing Version: {this.InstallationModel.NoticeModel.ExistingVersion}");
			this.Session.Log($"Session Installing: {this.Session.IsInstalling}");
			this.Session.Log($"Session Uninstalling: {this.Session.IsUninstalling}");
			this.Session.Log($"Session Rollback: {this.Session.IsRollback}");
			this.Session.Log($"Session Upgrading: {this.Session.IsUpgrading}");

			if (!this.ServiceStateProvider.Running && this.ServiceStateProvider.SeesService)
			{
				this.Session.Log($"{nameof(EnsureServiceStartTask)}: Service installed and not running. Attempting to start");
				this.ServiceStateProvider.StartAndWaitForRunning(TimeSpan.FromSeconds(60));

			}

			return true;
		}
	}
}