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

using System;
using System.Threading.Tasks;
using Angular.AuthInfrastructure.App_Packages.LibLog._2._0;
using Angular.AuthInfrastructure.Services;

namespace Angular.AuthInfrastructure.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="ICache{T}"/>
    /// </summary>
    public static class ICacheExtensions
    {
        private static readonly ILog Logger = LogProvider.GetLogger("Cache");

        /// <summary>
        /// Attempts to get an item from the cache. If the item is not found, the <c>get</c> function is used to 
        /// obtain the item and populate the cache.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache">The cache.</param>
        /// <param name="key">The key.</param>
        /// <param name="get">The get function.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">
        /// cache
        /// or
        /// get
        /// </exception>
        public static async Task<T> GetAsync<T>(this ICache<T> cache, string key, Func<Task<T>> get)
            where T : class
        {
            if (cache == null) throw new ArgumentNullException("cache");
            if (get == null) throw new ArgumentNullException("get");
            if (key == null) return null;

            T item = await cache.GetAsync(key);
            
            if (item == null)
            {
                Logger.Debug("Cache miss: " + key);

                item = await get();

                if (item != null)
                {
                    await cache.SetAsync(key, item);
                }
            }
            else
            {
                Logger.Debug("Cache hit: " + key);
            }
            
            return item;
        }
    }
}