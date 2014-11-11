﻿//Copyright 2014 Spin Services Limited

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using System.Web.Http;
using System.Web.Http.Dispatcher;
using SS.Integration.Adapter.Diagnostic.RestService.Handlers;

namespace SS.Integration.Adapter.Diagnostic.RestService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            // enable 404 errors redirect
            // TODO: make it configurable
            // MUST be the last one!

            config.Routes.MapHttpRoute(
                name: "Error404",
                routeTemplate: "{*url}", // invalid URL character, so this will never be called externally
                defaults: new {controller = "Error", action = "Handle404"}
                );
        }
    }
}