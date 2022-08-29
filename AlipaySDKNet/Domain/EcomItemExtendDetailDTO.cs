using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomItemExtendDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomItemExtendDetailDTO : AopObject
    {
        /// <summary>
        /// extInfo
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 游戏账号
        /// </summary>
        [XmlElement("game_account")]
        public string GameAccount { get; set; }

        /// <summary>
        /// 游戏账号所属客户端
        /// </summary>
        [XmlElement("game_account_client")]
        public string GameAccountClient { get; set; }

        /// <summary>
        /// 游戏账号所属客户端id
        /// </summary>
        [XmlElement("game_account_client_id")]
        public string GameAccountClientId { get; set; }

        /// <summary>
        /// 游戏id
        /// </summary>
        [XmlElement("game_id")]
        public string GameId { get; set; }

        /// <summary>
        /// 游戏名称
        /// </summary>
        [XmlElement("game_name")]
        public string GameName { get; set; }
    }
}
