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
using System.Collections.Generic;
using SS.Integration.Adapter.Diagnostics.Model.Service.Interface;
using SS.Integration.Adapter.Interface;
using SS.Integration.Adapter.Model.Interfaces;

namespace SS.Integration.Adapter.Diagnostics.Model.Interface
{
    public interface ISupervisor : IStreamListenerManager, IDisposable
    {
        ISupervisorProxy Proxy { get; }
        ISupervisorService Service { get; }
        
        IObservable<IFixtureOverviewDelta> GetFixtureOverviewStream(string fixtureId);
        IObservable<IFixtureOverviewDelta> GetAllFixtureOverviewStreams();
        IEnumerable<IFixtureOverview> GetFixtures();
        IFixtureOverview GetFixtureOverview(string fixtureId);

        IEnumerable<ISportOverview> GetSports();
        ISportOverview GetSportOverview(string sportCode);
        IObservable<ISportOverview> GetSportOverviewStream(string sportCode);
        IObservable<ISportOverview> GetAllSportOverviewStreams();

        IAdapterVersion GetAdapterVersion();


        void RemoveFixtureState(string fixtureId);
        void ForceSnapshot(string fixtureId);
        void ForceListenerStop(string fixtureId);

        void Initialise();
    }
}

