// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.PowerShell.PowerShellGet.UtilClasses;
using System.Collections.Generic;

namespace Microsoft.PowerShell.PowerShellGet.Cmdlets
{
    internal abstract class ResponseUtil
    {
        #region Members

        internal abstract PSRepositoryInfo Repository { get; set; }

        #endregion

        #region Constructor

        public ResponseUtil(PSRepositoryInfo repository)
        {
            this.Repository = repository;
        }

        #endregion

        #region Methods

        public abstract IEnumerable<PSResourceResult> ConvertToPSResourceResult(FindResults responseResults);

        #endregion
    
    }
}
