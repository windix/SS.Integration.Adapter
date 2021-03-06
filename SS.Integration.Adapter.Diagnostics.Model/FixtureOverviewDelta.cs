//Copyright 2014 Spin Services Limited

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using System;
using SS.Integration.Adapter.Diagnostics.Model.Interface;

namespace SS.Integration.Adapter.Diagnostics.Model
{
    [Serializable]
    public class FixtureOverviewDelta : IFixtureOverviewDelta
    {
        public string Id { get; internal set; }
       
        public IListenerOverview ListenerOverview { get; internal set; }
        public ErrorOverview LastError { get; internal set; }
        public FeedUpdateOverview FeedUpdate { get; internal set; }

        public bool HasChanged
        {
            get { return ListenerOverview != null || LastError != null || FeedUpdate != null; }
        }
    }
}

