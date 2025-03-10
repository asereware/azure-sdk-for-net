// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create job operation. </summary>
    public partial class JobCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of JobCreateOrUpdateContent. </summary>
        public JobCreateOrUpdateContent()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the runbook. </summary>
        internal RunbookAssociationProperty Runbook { get; set; }
        /// <summary> Gets or sets the name of the runbook. </summary>
        public string RunbookName
        {
            get => Runbook is null ? default : Runbook.Name;
            set
            {
                if (Runbook is null)
                    Runbook = new RunbookAssociationProperty();
                Runbook.Name = value;
            }
        }

        /// <summary> Gets or sets the parameters of the job. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Gets or sets the runOn which specifies the group name where the job is to be executed. </summary>
        public string RunOn { get; set; }
    }
}
