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
using Angular.AuthInfrastructure.Models;

namespace Angular.AuthInfrastructure.Services
{
    /// <summary>
    /// Service to allow a subject to query and revoke client permissions.
    /// Provides an abstraction on the type of permission (codes, refresh tokens, access tokens, and consent).
    /// </summary>
    public interface IClientPermissionsService
    {
        /// <summary>
        /// Gets the client permissions for a subject.
        /// </summary>
        /// <param name="subject">The subject identifier.</param>
        /// <returns>A list of client permissions</returns>
        Task<IEnumerable<ClientPermission>> GetClientPermissionsAsync(string subject);

        /// <summary>
        /// Revokes the subject's permissions for a client.
        /// </summary>
        /// <param name="subject">The subject identifier.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <returns></returns>
        Task RevokeClientPermissionsAsync(string subject, string clientId);
    }
}