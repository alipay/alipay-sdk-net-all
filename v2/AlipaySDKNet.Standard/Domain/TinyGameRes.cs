using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TinyGameRes Data Structure.
    /// </summary>
    [Serializable]
    public class TinyGameRes : AopObject
    {
        /// <summary>
        /// 小游戏appId，用于创建计划时使用
        /// </summary>
        [XmlElement("tiny_game_id")]
        public string TinyGameId { get; set; }

        /// <summary>
        /// 小游戏具体名称
        /// </summary>
        [XmlElement("tiny_game_name")]
        public string TinyGameName { get; set; }
    }
}
