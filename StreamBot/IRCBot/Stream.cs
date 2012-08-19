/*
 * Copyright (C) 2012 Tomas Drbota
 *
 * This file is part of StreamBot.
 * StreamBot is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * StreamBot is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with StreamBot.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace StreamBot.IRCBot
{
    public class Stream
    {
        public string Name;
        public string URL;
        public string Subject;
        public int Status;

        // status
        //   0 = offline
        //   1 = online and was offline last tick
        //   2 = online and was online last tick
    }
}

