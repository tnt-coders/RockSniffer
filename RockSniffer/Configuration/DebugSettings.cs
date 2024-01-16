﻿using System;

namespace RockSniffer.Configuration
{
    [Serializable]
    public class DebugSettings
    {
        public bool disableVersionCheck = true; // Rock Buddy automatically bundles new versions
        public bool debugStateMachine = false;
        public bool debugSongDetails = false;
        public bool debugCache = false;
        public bool debugMemoryReadout = false;
        public bool debugSystemHandleQuery = false;
        public bool debugFileDetailQuery = false;
        public bool debugProcessingQueue = false;
    }
}
