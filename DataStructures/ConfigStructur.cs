﻿using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
// <auto-generated />
namespace BGEdit.ConfigStructur
{
 
    public partial class ConfigFile
    {
        [JsonProperty("config")]
        public Config Config { get; set; }
    }

    public partial class Config
    {
        [JsonProperty("RootFolder")]
        public RelativeDialoguePath RootFolder { get; set; }

        [JsonProperty("RelativeDialoguePath")]
        public RelativeDialoguePath RelativeDialoguePath { get; set; }

        [JsonProperty("RelativeLocalizationPath")]
        public RelativeDialoguePath RelativeLocalizationPath { get; set; }

        [JsonProperty("RelativeSpeakerGroupsPath")]
        public RelativeDialoguePath[] RelativeSpeakerGroupsPath { get; set; }

        [JsonProperty("RelativeOriginsPath")]
        public RelativeDialoguePath RelativeOriginsPath { get; set; }

        [JsonProperty("RelativeflagPaths")]
        public RelativePath[] RelativeflagPaths { get; set; }

        [JsonProperty("RelativeMergedPaths")]
        public RelativePath[] RelativeMergedPaths { get; set; }
    }

    public partial class RelativeDialoguePath
    {
        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public partial class RelativePath
    {
        [JsonProperty("Path")]
        public string Path { get; set; }
    }

}
