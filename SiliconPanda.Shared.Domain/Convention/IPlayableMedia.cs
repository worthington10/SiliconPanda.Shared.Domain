using System;
using System.Collections.Generic;
using System.Text;

namespace SiliconPanda.Shared.Domain.Convention
{
    public interface IPlayableMedia
    {
        string ContentType { get; set; }

        string Path { get; set; }
    }
}
