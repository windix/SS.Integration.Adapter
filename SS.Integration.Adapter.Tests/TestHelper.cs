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
using System.IO;
using Newtonsoft.Json;
using SS.Integration.Adapter.Model;
using SS.Integration.Common;

namespace SS.Integration.Adapter.Tests
{
    public class TestHelper
    {
        /// <summary>
        /// Returns sample json (stream message) with default Epoch 1 and Sequence 2
        /// </summary>
        internal static string GetRawStreamMessage(int epoch = 1, int sequence = 2, int epochChangeReason = 0, int matchStatus = 40)
        {
            return "{\"Relation\":\"http://c2e.sportingingsolutions.com/rels/v006/FootballOdds\",\"Content\":{\"Id\":\"y9s1fVzAoko805mzTnnTRU_CQy8\",\"Sequence\":##Sequence##,\"MatchStatus\":##MatchStatus##,\"Markets\":[{\"Id\":\"dt7InLy6LB59p46Ud3zH2sRGE6s\",\"Selections\":[{\"Id\":\"I-rKqC2k4BnSmrBZ3Ob4S7C5pMU\",\"Price\":1.94,\"Tradable\":false,\"Status\":1},{\"Id\":\"m-UqUafBAAEk0bOjqbcXQtMLdjc\",\"Price\":3.45,\"Tradable\":false,\"Status\":1},{\"Id\":\"mBljauqJRzBr3kgq7bfHd2aEUSU\",\"Price\":3.5,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"lQXyR3FUMzGM-gqjFgb8x7Wdc8A\",\"Selections\":[{\"Id\":\"UYA5pFpcqFpgTwZqqj785LNHtvw\",\"Price\":9.8,\"Tradable\":false,\"Status\":1},{\"Id\":\"uSIp2E6Dc-2gi5zZzjoBqcD9EpA\",\"Price\":4.6,\"Tradable\":false,\"Status\":1},{\"Id\":\"g29yNTqOY_YGIvReXfYYVUiO0R4\",\"Price\":3.7,\"Tradable\":false,\"Status\":1},{\"Id\":\"gGlCj6_h4iZpqFXV-DnQTs3WKHo\",\"Price\":4.1,\"Tradable\":false,\"Status\":1},{\"Id\":\"3NsggTU0pwY9WcNvNlpkPK5Rez0\",\"Price\":5.7,\"Tradable\":false,\"Status\":1},{\"Id\":\"7Ph0advEAN4f9Weg1mlpTwc5WLs\",\"Price\":9.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"Fz4Hrlk2SklD6jnYwEnxYpD-JWY\",\"Price\":14.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"iNwutelRlcyOXNA1X3HDQR-c86M\",\"Price\":22.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"rkrcrrGFLQ2Q8tHdLfe8jVdu_cA\",\"Price\":29.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"n9hTB4kOSLjFWCoh8CU8q3PqWAI\",\"Price\":33.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"B5b4OqH1wtm42gktt0CeNHLa-7Q\",\"Price\":34.0,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"TLjN6kWrH_vC4u8oZF8rpwou_o4\",\"Selections\":[{\"Id\":\"4vRGSlgg9aJdqH_nZKTYFK0W6Xc\",\"Price\":1.43,\"Tradable\":false,\"Status\":1},{\"Id\":\"x6b0aEg79FxyxIh6MekxmtulOkE\",\"Price\":3.8,\"Tradable\":false,\"Status\":1},{\"Id\":\"TpnAfJn2hEPQ-uYXQNV2A9HT944\",\"Price\":7.8,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"Hixf5MXUDgdpEqENjvTRqWAQS7w\",\"Selections\":[{\"Id\":\"RjlBZepVi_j2Ki9eapkekZ8DjC0\",\"Price\":4.15,\"Tradable\":false,\"Status\":1},{\"Id\":\"yR7JlUBU4TPENvGIIYTWisV7lLU\",\"Price\":1.21,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"DFIB4wxqKLUUDCBodTS3xttm_Aw\",\"Selections\":[{\"Id\":\"elnsgrevXmynuvnKsaokLcPB4Zw\",\"Price\":4.1,\"Tradable\":false,\"Status\":1},{\"Id\":\"VMKZXXkjTxZ-2enf0zd4BnEcg2c\",\"Price\":1.22,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"FItK4W_W5O4GyruTU86hw8HKRPc\",\"Selections\":[{\"Id\":\"Od5-H6cVmWuwLjBmJVLVk-AEfOQ\",\"Price\":5.5,\"Tradable\":false,\"Status\":1},{\"Id\":\"EQkA7T65UjUwZeH1NjuyOOP70LI\",\"Price\":1.13,\"Tradable\":false,\"Status\":1}]}],\"GameState\":{\"matchsummary\":\"0-0 00:00 1st\",\"concisematchsummary\":\"0-0 00:00 1st\",\"homepenalties\":0,\"awaypenalties\":0,\"homecorners\":0,\"awaycorners\":0,\"homeredcards\":0,\"awayredcards\":0,\"homeyellowcards\":0,\"awayyellowcards\":0,\"homewoodwork\":0,\"awaywoodwork\":0,\"homesubstitutions\":0,\"awaysubstitutions\":0},\"Epoch\":##Epoch##,\"LastEpochChangeReason\":[##EpochChangeReason##]}}".Replace("##Sequence##", sequence.ToString()).Replace("##Epoch##", epoch.ToString()).Replace("##EpochChangeReason##", epochChangeReason.ToString()).Replace("##MatchStatus##", matchStatus.ToString());
        }

        internal static string GetStreamUpdate(int epoch = 1, int sequence = 2, int epochChangeReason = 0,
                                               int matchStatus = 40)
        {
            return 
                "{\"Id\":\"y9s1fVzAoko805mzTnnTRU_CQy8\",\"Sequence\":##Sequence##,\"MatchStatus\":##MatchStatus##,\"Markets\":[{\"Id\":\"dt7InLy6LB59p46Ud3zH2sRGE6s\",\"Selections\":[{\"Id\":\"I-rKqC2k4BnSmrBZ3Ob4S7C5pMU\",\"Price\":1.94,\"Tradable\":false,\"Status\":1},{\"Id\":\"m-UqUafBAAEk0bOjqbcXQtMLdjc\",\"Price\":3.45,\"Tradable\":false,\"Status\":1},{\"Id\":\"mBljauqJRzBr3kgq7bfHd2aEUSU\",\"Price\":3.5,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"lQXyR3FUMzGM-gqjFgb8x7Wdc8A\",\"Selections\":[{\"Id\":\"UYA5pFpcqFpgTwZqqj785LNHtvw\",\"Price\":9.8,\"Tradable\":false,\"Status\":1},{\"Id\":\"uSIp2E6Dc-2gi5zZzjoBqcD9EpA\",\"Price\":4.6,\"Tradable\":false,\"Status\":1},{\"Id\":\"g29yNTqOY_YGIvReXfYYVUiO0R4\",\"Price\":3.7,\"Tradable\":false,\"Status\":1},{\"Id\":\"gGlCj6_h4iZpqFXV-DnQTs3WKHo\",\"Price\":4.1,\"Tradable\":false,\"Status\":1},{\"Id\":\"3NsggTU0pwY9WcNvNlpkPK5Rez0\",\"Price\":5.7,\"Tradable\":false,\"Status\":1},{\"Id\":\"7Ph0advEAN4f9Weg1mlpTwc5WLs\",\"Price\":9.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"Fz4Hrlk2SklD6jnYwEnxYpD-JWY\",\"Price\":14.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"iNwutelRlcyOXNA1X3HDQR-c86M\",\"Price\":22.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"rkrcrrGFLQ2Q8tHdLfe8jVdu_cA\",\"Price\":29.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"n9hTB4kOSLjFWCoh8CU8q3PqWAI\",\"Price\":33.0,\"Tradable\":false,\"Status\":1},{\"Id\":\"B5b4OqH1wtm42gktt0CeNHLa-7Q\",\"Price\":34.0,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"TLjN6kWrH_vC4u8oZF8rpwou_o4\",\"Selections\":[{\"Id\":\"4vRGSlgg9aJdqH_nZKTYFK0W6Xc\",\"Price\":1.43,\"Tradable\":false,\"Status\":1},{\"Id\":\"x6b0aEg79FxyxIh6MekxmtulOkE\",\"Price\":3.8,\"Tradable\":false,\"Status\":1},{\"Id\":\"TpnAfJn2hEPQ-uYXQNV2A9HT944\",\"Price\":7.8,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"Hixf5MXUDgdpEqENjvTRqWAQS7w\",\"Selections\":[{\"Id\":\"RjlBZepVi_j2Ki9eapkekZ8DjC0\",\"Price\":4.15,\"Tradable\":false,\"Status\":1},{\"Id\":\"yR7JlUBU4TPENvGIIYTWisV7lLU\",\"Price\":1.21,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"DFIB4wxqKLUUDCBodTS3xttm_Aw\",\"Selections\":[{\"Id\":\"elnsgrevXmynuvnKsaokLcPB4Zw\",\"Price\":4.1,\"Tradable\":false,\"Status\":1},{\"Id\":\"VMKZXXkjTxZ-2enf0zd4BnEcg2c\",\"Price\":1.22,\"Tradable\":false,\"Status\":1}]},{\"Id\":\"FItK4W_W5O4GyruTU86hw8HKRPc\",\"Selections\":[{\"Id\":\"Od5-H6cVmWuwLjBmJVLVk-AEfOQ\",\"Price\":5.5,\"Tradable\":false,\"Status\":1},{\"Id\":\"EQkA7T65UjUwZeH1NjuyOOP70LI\",\"Price\":1.13,\"Tradable\":false,\"Status\":1}]}],\"GameState\":{\"matchsummary\":\"0-0 00:00 1st\",\"concisematchsummary\":\"0-0 00:00 1st\",\"homepenalties\":0,\"awaypenalties\":0,\"homecorners\":0,\"awaycorners\":0,\"homeredcards\":0,\"awayredcards\":0,\"homeyellowcards\":0,\"awayyellowcards\":0,\"homewoodwork\":0,\"awaywoodwork\":0,\"homesubstitutions\":0,\"awaysubstitutions\":0},\"Epoch\":##Epoch##,\"LastEpochChangeReason\":[##EpochChangeReason##]}"
                    .Replace("##Sequence##", sequence.ToString())
                    .Replace("##Epoch##", epoch.ToString())
                    .Replace("##EpochChangeReason##", epochChangeReason.ToString())
                    .Replace("##MatchStatus##", matchStatus.ToString());
        }

        /// <summary>
        /// Returns sample json (Snapshot) with default Epoch 1 and Sequence 2
        /// </summary>
        internal static string GetSnapshotJson(int epoch = 1, int sequence = 2, int epochChangeReason = 0, int matchStatus = 40)
        {
            return "{\"Id\":\"TestFixtureId\",\"Sequence\":##Sequence##,\"MatchStatus\":##MatchStatus##,\"Tags\":{\"StartTime\":\"2013-04-09T22:15:00Z\",\"CompetitionName\":\"Copa Libertadores\",\"CompetitionType\":\"UNKNOWN\",\"TournamentType\":\"UNKNOWN\",\"TournamentName\":\"UNKNOWN\",\"Round\":\"UNKNOWN\",\"Jurisdiction\":\"Copa\",\"Gender\":\"UNKNOWN\",\"PreMatchOnly\":false,\"Sport\":\"Football\"},\"Markets\":[{\"Id\":\"dt7InLy6LB59p46Ud3zH2sRGE6s\",\"Selections\":[{\"Id\":\"I-rKqC2k4BnSmrBZ3Ob4S7C5pMU\",\"Price\":1.24,\"Tradable\":false,\"Status\":1,\"Tags\":{\"team\":\"1\",\"name\":\"Penarol\"}},{\"Id\":\"m-UqUafBAAEk0bOjqbcXQtMLdjc\",\"Price\":5.5,\"Tradable\":false,\"Status\":1,\"Tags\":{\"team\":\"3\",\"name\":\"Draw\"}},{\"Id\":\"mBljauqJRzBr3kgq7bfHd2aEUSU\",\"Price\":9.8,\"Tradable\":false,\"Status\":1,\"Tags\":{\"team\":\"2\",\"name\":\"Deportes Iquique\"}}],\"Tags\":{\"type\":\"match_winner\",\"traded_pre_match\":\"true\",\"traded_in_play\":\"true\",\"name\":\"Match Winner\"}},{\"Id\":\"lQXyR3FUMzGM-gqjFgb8x7Wdc8A\",\"Selections\":[{\"Id\":\"UYA5pFpcqFpgTwZqqj785LNHtvw\",\"Price\":13.0,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"0\",\"name\":\"No Goal\"}},{\"Id\":\"uSIp2E6Dc-2gi5zZzjoBqcD9EpA\",\"Price\":5.8,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"1\",\"name\":\"Exactly 1 Goal\"}},{\"Id\":\"g29yNTqOY_YGIvReXfYYVUiO0R4\",\"Price\":4.1,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"2\",\"name\":\"Exactly 2 Goals\"}},{\"Id\":\"gGlCj6_h4iZpqFXV-DnQTs3WKHo\",\"Price\":4.05,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"3\",\"name\":\"Exactly 3 Goals\"}},{\"Id\":\"3NsggTU0pwY9WcNvNlpkPK5Rez0\",\"Price\":5.0,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"4\",\"name\":\"Exactly 4 Goals\"}},{\"Id\":\"7Ph0advEAN4f9Weg1mlpTwc5WLs\",\"Price\":7.4,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"5\",\"name\":\"Exactly 5 Goals\"}},{\"Id\":\"Fz4Hrlk2SklD6jnYwEnxYpD-JWY\",\"Price\":10.0,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"6\",\"name\":\"Exactly 6 Goals\"}},{\"Id\":\"iNwutelRlcyOXNA1X3HDQR-c86M\",\"Price\":17.0,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"7\",\"name\":\"Exactly 7 Goals\"}},{\"Id\":\"rkrcrrGFLQ2Q8tHdLfe8jVdu_cA\",\"Price\":25.0,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"8\",\"name\":\"Exactly 8 Goals\"}},{\"Id\":\"n9hTB4kOSLjFWCoh8CU8q3PqWAI\",\"Price\":31.0,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"exactly\",\"line\":\"9\",\"name\":\"Exactly 9 Goals\"}},{\"Id\":\"B5b4OqH1wtm42gktt0CeNHLa-7Q\",\"Price\":33.0,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"atleast\",\"line\":\"10\",\"name\":\"10 Goals Or More\"}}],\"Tags\":{\"type\":\"total_goals\",\"traded_pre_match\":\"true\",\"traded_in_play\":\"true\",\"name\":\"Total Goals\"}},{\"Id\":\"TLjN6kWrH_vC4u8oZF8rpwou_o4\",\"Selections\":[{\"Id\":\"4vRGSlgg9aJdqH_nZKTYFK0W6Xc\",\"Price\":0.0,\"Tradable\":false,\"Status\":0,\"Tags\":{\"team\":\"1\",\"name\":\"Penarol\"}},{\"Id\":\"TpnAfJn2hEPQ-uYXQNV2A9HT944\",\"Price\":0.0,\"Tradable\":false,\"Status\":0,\"Tags\":{\"team\":\"3\",\"name\":\"Draw\"}},{\"Id\":\"x6b0aEg79FxyxIh6MekxmtulOkE\",\"Price\":0.0,\"Tradable\":false,\"Status\":0,\"Tags\":{\"team\":\"2\",\"name\":\"Deportes Iquique\"}}],\"Tags\":{\"type\":\"corners_match_bet\",\"traded_pre_match\":\"true\",\"traded_in_play\":\"true\",\"name\":\"Team With Most Corners\"}},{\"Id\":\"Hixf5MXUDgdpEqENjvTRqWAQS7w\",\"Selections\":[{\"Id\":\"RjlBZepVi_j2Ki9eapkekZ8DjC0\",\"Price\":5.3,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"yes\",\"name\":\"Yes\"}},{\"Id\":\"yR7JlUBU4TPENvGIIYTWisV7lLU\",\"Price\":1.14,\"Tradable\":false,\"Status\":1,\"Tags\":{\"identifier\":\"no\",\"name\":\"No\"}}],\"Tags\":{\"type\":\"match_red_card\",\"traded_pre_match\":\"true\",\"traded_in_play\":\"true\",\"name\":\"Will There Be A Red Card?\"}},{\"Id\":\"DFIB4wxqKLUUDCBodTS3xttm_Aw\",\"Selections\":[{\"Id\":\"elnsgrevXmynuvnKsaokLcPB4Zw\",\"Price\":0.0,\"Tradable\":false,\"Status\":0,\"Tags\":{\"identifier\":\"yes\",\"name\":\"Yes\"}},{\"Id\":\"VMKZXXkjTxZ-2enf0zd4BnEcg2c\",\"Price\":0.0,\"Tradable\":false,\"Status\":0,\"Tags\":{\"identifier\":\"no\",\"name\":\"No\"}}],\"Tags\":{\"type\":\"penalty_awarded\",\"traded_pre_match\":\"true\",\"traded_in_play\":\"true\",\"name\":\"Will There Be A Penalty Awarded?\"}},{\"Id\":\"FItK4W_W5O4GyruTU86hw8HKRPc\",\"Selections\":[{\"Id\":\"Od5-H6cVmWuwLjBmJVLVk-AEfOQ\",\"Price\":0.0,\"Tradable\":false,\"Status\":0,\"Tags\":{\"identifier\":\"yes\",\"name\":\"Yes\"}},{\"Id\":\"EQkA7T65UjUwZeH1NjuyOOP70LI\",\"Price\":0.0,\"Tradable\":false,\"Status\":0,\"Tags\":{\"identifier\":\"no\",\"name\":\"No\"}}],\"Tags\":{\"type\":\"penalty_scored\",\"traded_pre_match\":\"true\",\"traded_in_play\":\"true\",\"name\":\"Will There Be A Penalty Scored?\"}}],\"GameState\":{\"matchsummary\":\"0-0 00:00 1st\",\"concisematchsummary\":\"0-0 00:00 1st\",\"homepenalties\":0,\"awaypenalties\":0,\"homecorners\":0,\"awaycorners\":0,\"homeredcards\":0,\"awayredcards\":0,\"homeyellowcards\":0,\"awayyellowcards\":0,\"homewoodwork\":0,\"awaywoodwork\":0,\"homesubstitutions\":0,\"awaysubstitutions\":0},\"Epoch\":##Epoch##,\"LastEpochChangeReason\":[##EpochChangeReason##],\"Participants\":[{\"Id\":1,\"Tags\":{\"HomeOrAway\":\"Home\",\"IndividualOrTeam\":\"Team\"},\"Name\":\"Penarol\",\"SubParticpants\":[{\"Id\":1,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 01 Home$\"},{\"Id\":2,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 02 Home$\"},{\"Id\":3,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 03 Home$\"},{\"Id\":4,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 04 Home$\"},{\"Id\":5,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 05 Home$\"},{\"Id\":6,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 06 Home$\"},{\"Id\":7,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 07 Home$\"},{\"Id\":8,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 08 Home$\"},{\"Id\":9,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 09 Home$\"},{\"Id\":10,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 10 Home$\"},{\"Id\":11,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 11 Home$\"},{\"Id\":12,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 12 Home$\"},{\"Id\":13,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 13 Home$\"},{\"Id\":14,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 14 Home$\"},{\"Id\":15,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 15 Home$\"},{\"Id\":16,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 16 Home$\"},{\"Id\":17,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 17 Home$\"},{\"Id\":18,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 18 Home$\"},{\"Id\":19,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 19 Home$\"},{\"Id\":20,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 20 Home$\"},{\"Id\":21,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 21 Home$\"},{\"Id\":22,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 22 Home$\"},{\"Id\":23,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 23 Home$\"},{\"Id\":24,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 24 Home$\"},{\"Id\":25,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 25 Home$\"},{\"Id\":26,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 26 Home$\"},{\"Id\":27,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 27 Home$\"},{\"Id\":28,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 28 Home$\"},{\"Id\":29,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 29 Home$\"},{\"Id\":30,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 30 Home$\"},{\"Id\":31,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 31 Home$\"},{\"Id\":32,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 32 Home$\"},{\"Id\":33,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 33 Home$\"},{\"Id\":34,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 34 Home$\"},{\"Id\":35,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 35 Home$\"},{\"Id\":36,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 36 Home$\"},{\"Id\":37,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 37 Home$\"},{\"Id\":38,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 38 Home$\"},{\"Id\":39,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 39 Home$\"},{\"Id\":40,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Home$\"},\"Name\":\"$Player 40 Home$\"}]},{\"Id\":2,\"Tags\":{\"HomeOrAway\":\"Away\",\"IndividualOrTeam\":\"Team\"},\"Name\":\"Deportes Iquique\",\"SubParticpants\":[{\"Id\":1,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 41 Away$\"},{\"Id\":2,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 42 Away$\"},{\"Id\":3,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 43 Away$\"},{\"Id\":4,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 44 Away$\"},{\"Id\":5,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 45 Away$\"},{\"Id\":6,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 46 Away$\"},{\"Id\":7,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 47 Away$\"},{\"Id\":8,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 48 Away$\"},{\"Id\":9,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 49 Away$\"},{\"Id\":10,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 50 Away$\"},{\"Id\":11,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 51 Away$\"},{\"Id\":12,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 52 Away$\"},{\"Id\":13,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 53 Away$\"},{\"Id\":14,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 54 Away$\"},{\"Id\":15,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 55 Away$\"},{\"Id\":16,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 56 Away$\"},{\"Id\":17,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 57 Away$\"},{\"Id\":18,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 58 Away$\"},{\"Id\":19,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 59 Away$\"},{\"Id\":20,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 60 Away$\"},{\"Id\":21,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 61 Away$\"},{\"Id\":22,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 62 Away$\"},{\"Id\":23,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 63 Away$\"},{\"Id\":24,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 64 Away$\"},{\"Id\":25,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 65 Away$\"},{\"Id\":26,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 66 Away$\"},{\"Id\":27,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 67 Away$\"},{\"Id\":28,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 68 Away$\"},{\"Id\":29,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 69 Away$\"},{\"Id\":30,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 70 Away$\"},{\"Id\":31,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 71 Away$\"},{\"Id\":32,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 72 Away$\"},{\"Id\":33,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 73 Away$\"},{\"Id\":34,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 74 Away$\"},{\"Id\":35,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 75 Away$\"},{\"Id\":36,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 76 Away$\"},{\"Id\":37,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 77 Away$\"},{\"Id\":38,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 78 Away$\"},{\"Id\":39,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 79 Away$\"},{\"Id\":40,\"Tags\":{\"firstname\":\"$Player\",\"lastname\":\"Away$\"},\"Name\":\"$Player 80 Away$\"}]}],\"StartTime\":\"2013-04-09T22:15:00Z\"}".Replace("##Sequence##", sequence.ToString()).Replace("##Epoch##", epoch.ToString()).Replace("##EpochChangeReason##", epochChangeReason.ToString()).Replace("##MatchStatus##", matchStatus.ToString());
		}

        internal static Fixture GetFixtureFromResource(string resource_name)
        {
            byte[] data = null;
            string sport;

            switch (resource_name)
            {
                case "rugbydata_snapshot_2":
                    data = FixtureSamples.rugbydata_snapshot_2;
                    sport = "RugbyLeague";
                    break;
                case "rugbydata_snapshot_4":
                    data = FixtureSamples.rugbydata_snapshot_4;
                    sport = "RugbyLeague";
                    break;
                case "rugbydata_update_3":
                    data = FixtureSamples.rugbydata_update_3;
                    sport = "RugbyLeague";
                    break;
                case "rugbydata_update_4":
                    data = FixtureSamples.rugbydata_update_4;
                    sport = "v";
                    break;
                case "rugbydata_snapshot_withRemovedMarkets_5":
                    data = FixtureSamples.rugbydata_snapshot_withRemovedMarkets_5;
                    sport = "RugbyLeague";
                    break;
                case "horseracing":
                    data = FixtureSamples.horseracing;
                    sport = "HorseRacing";
                    break;
                case "football-inplay-snapshot-2":
                    data = FixtureSamples.football_inplay_snapshot_2;
                    sport = "Football";
                    break;
                default:
                    throw new Exception("Unknown fixture");

            }

            using (Stream stream = new MemoryStream(data))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var tmp = reader.ReadToEnd();
                    Fixture fixture = JsonConvert.DeserializeObject<Fixture>(tmp, FixtureDateTimeJsonConverter.Instance);

                    if (!fixture.Tags.ContainsKey("Sport"))
                        fixture.Tags.Add("Sport", sport);

                    return fixture;
                }
            }

        }
    }
}
