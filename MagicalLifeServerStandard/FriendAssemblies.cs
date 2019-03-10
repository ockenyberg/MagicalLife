﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("MagicalLifeAPITest")]
[assembly: InternalsVisibleTo("MagicalLifeClientStandard")]
[assembly: InternalsVisibleTo("MagicalLifeDedicatedServerCore")]
[assembly: InternalsVisibleTo("MagicalLifeGUIWindows")]
[assembly: InternalsVisibleTo("MagicalLifeModdingAPI")]
[assembly: InternalsVisibleTo("MagicalLifeAPIStandard")]
[assembly: InternalsVisibleTo("MagicalLifeSettingsStandard")]

namespace MagicalLifeServer
{
    /// <summary>
    /// Used to control who has access to internal members of this assembly.
    /// </summary>
    public class FriendAssemblies
    {
    }
}
