using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Map_To_Image.src.logic.utils
{
   public static class Enums
    {
        public enum Minecraft
        {
            Java,
            Bedrock
        }

        public enum MinecraftDimension
        {
            Nether = -1,
            Overworld = 0,
            The_End = 1,
        }
    }
}
