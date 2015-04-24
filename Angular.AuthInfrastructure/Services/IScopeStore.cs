﻿/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Models;

namespace Thinktecture.IdentityServer.Core.Services
{
    /// <summary>
    /// Scope retrieval
    /// </summary>
    public interface IScopeStore
    {
        /// <summary>
        /// Gets all scopes.
        /// </summary>
        /// <returns>List of scopes</returns>
        Task<IEnumerable<Scope>> FindScopesAsync(IEnumerable<string> scopeNames);

        /// <summary>
        /// Gets all defined scopes.
        /// </summary>
        /// <param name="publicOnly">if set to <c>true</c> only public scopes are returned.</param>
        /// <returns></returns>
        Task<IEnumerable<Scope>> GetScopesAsync(bool publicOnly = true);
    }
}