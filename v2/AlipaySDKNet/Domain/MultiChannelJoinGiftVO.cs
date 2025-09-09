using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiChannelJoinGiftVO Data Structure.
    /// </summary>
    [Serializable]
    public class MultiChannelJoinGiftVO : AopObject
    {
        /// <summary>
        /// 群组id，表里唯一键，创建群组自动生成
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 定义群组分类，便于后台管理运营识别，可与设置的群名称保持一致；例：xx门店群，内部测试群
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 入群有礼列表
        /// </summary>
        [XmlArray("join_gifts")]
        [XmlArrayItem("group_gift_v_o")]
        public List<GroupGiftVO> JoinGifts { get; set; }
    }
}
