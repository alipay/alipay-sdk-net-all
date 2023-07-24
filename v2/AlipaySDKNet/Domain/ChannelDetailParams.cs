using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelDetailParams Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelDetailParams : AopObject
    {
        /// <summary>
        /// 预付卡分组名称
        /// </summary>
        [XmlElement("card_group_name")]
        public string CardGroupName { get; set; }
    }
}
