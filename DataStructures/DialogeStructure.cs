﻿using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
// <partial auto-generated/>
namespace BGEdit
{

    public partial class DialogueStructurRoot
    {
        [JsonProperty("save")]
        public Save Save { get; set; }
    }

    public partial class Save
    {
        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("regions")]
        public Regions Regions { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public partial class Regions
    {
        [JsonProperty("dialog")]
        public Dialog Dialog { get; set; }

        [JsonProperty("editorData")]
        public EditorData EditorData { get; set; }
    }

    public partial class Dialog
    {
        [JsonProperty("DefaultAddressedSpeakers")]
        public DefaultAddressedSpeaker[] DefaultAddressedSpeakers { get; set; }

        [JsonProperty("IsAllowingJoinCombat")]
        public IsAllowingJoinCombat IsAllowingJoinCombat { get; set; }

        [JsonProperty("TimelineId")]
        public TimelineId TimelineId { get; set; }

        [JsonProperty("UUID")]
        public TimelineId Uuid { get; set; }

        [JsonProperty("automated")]
        public IsAllowingJoinCombat Automated { get; set; }

        [JsonProperty("category")]
        public TimelineId Category { get; set; }

        [JsonProperty("nodes")]
        public DialogNode[] Nodes { get; set; }

        [JsonProperty("speakerlist")]
        public Speakerlist[] Speakerlist { get; set; }
    }

    public partial class IsAllowingJoinCombat
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public partial class TimelineId
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    //todo remove
    public partial class DefaultAddressedSpeaker
    {
    }

    public partial class DialogNode
    {
        [JsonProperty("RootNodes")]
        public RootNode[] RootNodes { get; set; }

        [JsonProperty("node")]
        public NodeNode[] Node { get; set; }
    }

    public class UUID
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
    }
    public partial class Child
    {

        [JsonProperty("UUID")]
        public UUID UUID { get; set; }
    }

    public partial class Children
    {
        [JsonProperty("child")]
        public Child[] children { get; set; }
    }


    public class Jumptarget
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
    }


    public partial class Checkflag
    {
        [JsonProperty("flaggroup")]
        public Flaggroup[] flaggroup { get; set; }
    }
    public partial class Flaggroup
    {
        [JsonProperty("flag")]
        public List<Flag> flag { get; set; }

        [JsonProperty("type")]
        public FlaggroupType type { get; set; }
    }
    public partial class Flag
    {
        [JsonProperty("UUID")]
        public UUID UUID { get; set; }

        [JsonProperty("value")]
        public Value value { get; set; }
    }

    public partial class FlaggroupType
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
    }
    public partial class Value
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("value")]
        public bool value { get; set; }
    }

    public partial class NodeNode
    {
        [JsonProperty("checkflags")]
        public Checkflag[] Checkflags { get; set; }

        [JsonProperty("GameData")]
        public GameDatum[] GameData { get; set; }

        [JsonProperty("jumptarget")]
        public Jumptarget Jumptarget { get; set; }

        [JsonProperty("Root")]
        public IsAllowingJoinCombat Root { get; set; }

        [JsonProperty("TaggedTexts")]
        public NodeTaggedText[] TaggedTexts { get; set; }

        [JsonProperty("Tags")]
        public DefaultAddressedSpeaker[] Tags { get; set; }

        [JsonProperty("UUID")]
        public TimelineId Uuid { get; set; }


        [JsonProperty("GroupID")]
        public TimelineId GroupID { get; set; }

        [JsonProperty("GroupIndex")]
        public TimelineId GroupIndex { get; set; }

        [JsonProperty("children")]
        public Children[] children { get; set; }

        [JsonProperty("constructor")]
        public TimelineId Constructor { get; set; }

        [JsonProperty("editorData")]
        public DefaultAttitude[] EditorData { get; set; }

        [JsonProperty("endnode")]
        public IsAllowingJoinCombat Endnode { get; set; }

        [JsonProperty("setflags")]
        public DefaultAddressedSpeaker[] Setflags { get; set; }

        [JsonProperty("speaker")]
        public NextNodeId Speaker { get; set; }
    }

    public partial class DefaultAttitude
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("key")]
        public TimelineId Key { get; set; }

        [JsonProperty("val")]
        public TimelineId Val { get; set; }
    }

    public partial class GameDatum
    {
        [JsonProperty("AiPersonalities")]
        public DefaultAddressedSpeaker[] AiPersonalities { get; set; }

        [JsonProperty("MusicInstrumentSounds")]
        public DefaultAddressedSpeaker[] MusicInstrumentSounds { get; set; }

        [JsonProperty("OriginSound")]
        public DefaultAddressedSpeaker[] OriginSound { get; set; }
    }

    public partial class NextNodeId
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public partial class NodeTaggedText
    {
        [JsonProperty("TaggedText")]
        public TaggedTextTaggedText[] TaggedText { get; set; }
    }
    public partial class RuleGroup
    {
        [JsonProperty("Rules")]
        public RuleGroupRule[] Rules { get; set; }

        [JsonProperty("TagCombineOp")]
        public TagCombineOp TagCombineOp { get; set; }
    }

    public partial class RuleGroupRule
    {
        [JsonProperty("Rule")]
        public RuleRule[] Rule { get; set; }
    }

    public partial class RuleRule
    {
        [JsonProperty("HasChildRules")]
        public HasChildRules HasChildRules { get; set; }

        [JsonProperty("TagCombineOp")]
        public TagCombineOp TagCombineOp { get; set; }

        [JsonProperty("Tags")]
        public RuleTag[] Tags { get; set; }

        [JsonProperty("speaker")]
        public TagCombineOp Speaker { get; set; }
    }

    public partial class HasChildRules
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public partial class TagCombineOp
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public partial class RuleTag
    {
        [JsonProperty("Tag")]
        public TagTag[] Tag { get; set; }
    }

    public partial class TagTag
    {
        [JsonProperty("Object")]
        public Object Object { get; set; }
    }

    public partial class Object
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public Guid Value { get; set; }
    }
    public partial class TaggedTextTaggedText
    {
        [JsonProperty("HasTagRule")]
        public IsAllowingJoinCombat HasTagRule { get; set; }

        [JsonProperty("RuleGroup")]
        public RuleGroup[] RuleGroup { get; set; }

        [JsonProperty("TagTexts")]
        public TaggedTextTagText[] TagTexts { get; set; }
    }

    public partial class TaggedTextTagText
    {
        [JsonProperty("TagText")]
        public TagTextTagText[] TagTextArray { get; set; }
    }

    public partial class TagTextTagText
    {
        [JsonProperty("LineId")]
        public TimelineId LineId { get; set; }

        [JsonProperty("OldText")]
        public Text OldText { get; set; }

        [JsonProperty("TagText")]
        public Text TagText { get; set; }

        [JsonProperty("stub")]
        public IsAllowingJoinCombat Stub { get; set; }
    }

    public partial class Text
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }
    }

    public partial class RootNode
    {
        [JsonProperty("RootNodes")]
        public TimelineId RootNodes { get; set; }
    }

    public partial class Speakerlist
    {
        [JsonProperty("speaker")]
        public Speaker[] Speaker { get; set; }
    }

    public partial class Speaker
    {
        [JsonProperty("SpeakerMappingId")]
        public TimelineId SpeakerMappingId { get; set; }

        [JsonProperty("index")]
        public TimelineId Index { get; set; }

        [JsonProperty("list")]
        public TimelineId List { get; set; }
    }

    public partial class EditorData
    {
        [JsonProperty("HowToTrigger")]
        public TimelineId HowToTrigger { get; set; }

        [JsonProperty("defaultAttitudes")]
        public DefaultAttitude[] DefaultAttitudes { get; set; }

        [JsonProperty("defaultEmotions")]
        public DefaultAttitude[] DefaultEmotions { get; set; }

        [JsonProperty("isImportantForStagings")]
        public DefaultAttitude[] IsImportantForStagings { get; set; }

        [JsonProperty("isPeanuts")]
        public DefaultAttitude[] IsPeanuts { get; set; }

        [JsonProperty("needLayout")]
        public IsAllowingJoinCombat NeedLayout { get; set; }

        [JsonProperty("nextNodeId")]
        public NextNodeId NextNodeId { get; set; }

        [JsonProperty("speakerSlotDescription")]
        public DefaultAttitude[] SpeakerSlotDescription { get; set; }

        [JsonProperty("synopsis")]
        public TimelineId Synopsis { get; set; }
    }

    public enum TypeEnum { FixedString, Guid, LsString };

    public partial class DialogueStructurRoot
    {
        public static DialogueStructurRoot FromJson(string json) => JsonConvert.DeserializeObject<DialogueStructurRoot>(json, BGEdit.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DialogueStructurRoot self) => JsonConvert.SerializeObject(self, BGEdit.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FixedString":
                    return TypeEnum.FixedString;
                case "LSString":
                    return TypeEnum.LsString;
                case "guid":
                    return TypeEnum.Guid;
                default:
                    return TypeEnum.LsString;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.FixedString:
                    serializer.Serialize(writer, "FixedString");
                    return;
                case TypeEnum.LsString:
                    serializer.Serialize(writer, "LSString");
                    return;
                case TypeEnum.Guid:
                    serializer.Serialize(writer, "guid");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

}
