﻿using System.Collections.Generic;

namespace EternalModLoader
{
    /// <summary>
    /// Resource info class
    /// </summary>
    public class ResourceInfo
    {
        /// <summary>
        /// Resource name
        /// </summary>
        public string Name;

        /// <summary>
        /// Resource file path
        /// </summary>
        public string Path;

        /// <summary>
        /// 0x20
        /// </summary>
        public int FileCount;

        /// <summary>
        /// 0x28
        /// </summary>
        public int TypeCount;

        /// <summary>
        /// 0x38
        /// </summary>
        public int StringsSize;

        /// <summary>
        /// 0x40
        /// </summary>
        public long NamesOffset;

        /// <summary>
        /// 0x50 (almost always 7C)
        /// </summary>
        public long InfoOffset;

        /// <summary>
        /// 0x60 (offset of where we can get NameIds)
        /// </summary>
        public long Dummy7Offset;

        /// <summary>
        /// 0x68 (offset of chunks start)
        /// </summary>
        public long DataOffset;

        /// <summary>
        /// 0x74 (offset of 2nd IDCL)
        /// </summary>
        public long IdclOffset;

        /// <summary>
        /// 0x24 (num of entries in section after NamesEnd)
        /// </summary>
        public int UnknownCount;

        /// <summary>
        /// 0x2C (double the FileCount)
        /// </summary>
        public int FileCount2;

        /// <summary>
        /// Separator between name offsets and names
        /// </summary>
        public long NamesOffsetEnd;

        /// <summary>
        /// 0x48 (unknown section offset)
        /// </summary>
        public long UnknownOffset;

        /// <summary>
        /// 0x58 (same as UnknownOffset)
        /// </summary>
        public long UnknownOffset2;

        /// <summary>
        /// List containing all the chunks of the resource
        /// </summary>
        public List<ResourceChunk> ChunkList;

        /// <summary>
        /// Mod files that will be replaced in this resource
        /// </summary>
        public List<Mod> ModList;

        /// <summary>
        /// Mod files that will be added in this resource
        /// </summary>
        public List<Mod> ModListNew;

        /// <summary>
        /// List of all the file names in this resource
        /// </summary>
        public List<string> NamesList;

        /// <summary>
        /// Resource info constructor
        /// </summary>
        /// <param name="name">resource name</param>
        /// <param name="basePath">game base path</param>
        /// <param name="path">resource file path</param>
        public ResourceInfo(string name, string path)
        {
            Name = name;
            Path = path;
            ModList = new List<Mod>();
            ModListNew = new List<Mod>();
            NamesList = new List<string>();
            ChunkList = new List<ResourceChunk>();
        }
    }
}
