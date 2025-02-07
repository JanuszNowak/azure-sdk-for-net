// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration account agreement content. </summary>
    public partial class AgreementContent
    {
        /// <summary> Initializes a new instance of AgreementContent. </summary>
        public AgreementContent()
        {
        }

        /// <summary> Initializes a new instance of AgreementContent. </summary>
        /// <param name="aS2"> The AS2 agreement content. </param>
        /// <param name="x12"> The X12 agreement content. </param>
        /// <param name="edifact"> The EDIFACT agreement content. </param>
        internal AgreementContent(AS2AgreementContent aS2, X12AgreementContent x12, EdifactAgreementContent edifact)
        {
            AS2 = aS2;
            X12 = x12;
            Edifact = edifact;
        }

        /// <summary> The AS2 agreement content. </summary>
        public AS2AgreementContent AS2 { get; set; }
        /// <summary> The X12 agreement content. </summary>
        public X12AgreementContent X12 { get; set; }
        /// <summary> The EDIFACT agreement content. </summary>
        public EdifactAgreementContent Edifact { get; set; }
    }
}
