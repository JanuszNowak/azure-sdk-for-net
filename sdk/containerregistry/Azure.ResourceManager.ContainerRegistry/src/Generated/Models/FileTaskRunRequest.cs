// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The request parameters for a scheduling run against a task file. </summary>
    public partial class FileTaskRunRequest : RunContent
    {
        /// <summary> Initializes a new instance of FileTaskRunRequest. </summary>
        /// <param name="taskFilePath"> The template/definition file path relative to the source. </param>
        /// <param name="platform"> The platform properties against which the run has to happen. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskFilePath"/> or <paramref name="platform"/> is null. </exception>
        public FileTaskRunRequest(string taskFilePath, PlatformProperties platform)
        {
            if (taskFilePath == null)
            {
                throw new ArgumentNullException(nameof(taskFilePath));
            }
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }

            TaskFilePath = taskFilePath;
            Values = new ChangeTrackingList<SetValue>();
            Platform = platform;
            RunRequestType = "FileTaskRunRequest";
        }

        /// <summary> Initializes a new instance of FileTaskRunRequest. </summary>
        /// <param name="runRequestType"> The type of the run request. </param>
        /// <param name="isArchiveEnabled"> The value that indicates whether archiving is enabled for the run or not. </param>
        /// <param name="agentPoolName"> The dedicated agent pool for the run. </param>
        /// <param name="logTemplate"> The template that describes the repository and tag information for run log artifact. </param>
        /// <param name="taskFilePath"> The template/definition file path relative to the source. </param>
        /// <param name="valuesFilePath"> The values/parameters file path relative to the source. </param>
        /// <param name="values"> The collection of overridable values that can be passed when running a task. </param>
        /// <param name="timeout"> Run timeout in seconds. </param>
        /// <param name="platform"> The platform properties against which the run has to happen. </param>
        /// <param name="agentConfiguration"> The machine configuration of the run agent. </param>
        /// <param name="sourceLocation">
        /// The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.
        /// </param>
        /// <param name="credentials"> The properties that describes a set of credentials that will be used when this run is invoked. </param>
        internal FileTaskRunRequest(string runRequestType, bool? isArchiveEnabled, string agentPoolName, string logTemplate, string taskFilePath, string valuesFilePath, IList<SetValue> values, int? timeout, PlatformProperties platform, AgentProperties agentConfiguration, string sourceLocation, Credentials credentials) : base(runRequestType, isArchiveEnabled, agentPoolName, logTemplate)
        {
            TaskFilePath = taskFilePath;
            ValuesFilePath = valuesFilePath;
            Values = values;
            Timeout = timeout;
            Platform = platform;
            AgentConfiguration = agentConfiguration;
            SourceLocation = sourceLocation;
            Credentials = credentials;
            RunRequestType = runRequestType ?? "FileTaskRunRequest";
        }

        /// <summary> The template/definition file path relative to the source. </summary>
        public string TaskFilePath { get; set; }
        /// <summary> The values/parameters file path relative to the source. </summary>
        public string ValuesFilePath { get; set; }
        /// <summary> The collection of overridable values that can be passed when running a task. </summary>
        public IList<SetValue> Values { get; }
        /// <summary> Run timeout in seconds. </summary>
        public int? Timeout { get; set; }
        /// <summary> The platform properties against which the run has to happen. </summary>
        public PlatformProperties Platform { get; set; }
        /// <summary> The machine configuration of the run agent. </summary>
        internal AgentProperties AgentConfiguration { get; set; }
        /// <summary> The CPU configuration in terms of number of cores required for the run. </summary>
        public int? AgentCpu
        {
            get => AgentConfiguration is null ? default : AgentConfiguration.Cpu;
            set
            {
                if (AgentConfiguration is null)
                    AgentConfiguration = new AgentProperties();
                AgentConfiguration.Cpu = value;
            }
        }

        /// <summary>
        /// The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.
        /// </summary>
        public string SourceLocation { get; set; }
        /// <summary> The properties that describes a set of credentials that will be used when this run is invoked. </summary>
        public Credentials Credentials { get; set; }
    }
}
