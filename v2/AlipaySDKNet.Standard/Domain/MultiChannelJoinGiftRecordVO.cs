using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiChannelJoinGiftRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class MultiChannelJoinGiftRecordVO : AopObject
    {
        /// <summary>
        /// 配置渠道code列表
        /// </summary>
        [XmlArray("channel_list")]
        [XmlArrayItem("string")]
        public List<string> ChannelList { get; set; }

        /// <summary>
        /// 渠道名称列表
        /// </summary>
        [XmlArray("channel_name_list")]
        [XmlArrayItem("string")]
        public List<string> ChannelNameList { get; set; }

        /// <summary>
        /// 到期的入群有礼个数。单位：个数。
        /// </summary>
        [XmlElement("expire_cnt")]
        public long ExpireCnt { get; set; }

        /// <summary>
        /// 入群有礼渠道个数。单位：个数。
        /// </summary>
        [XmlElement("gift_cnt")]
        public long GiftCnt { get; set; }

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
        /// 有效入群有礼个数。单位：个数。
        /// </summary>
        [XmlElement("init_cnt")]
        public long InitCnt { get; set; }

        /// <summary>
        /// 失效入群有礼个数。单位：个数。
        /// </summary>
        [XmlElement("invalid_cnt")]
        public long InvalidCnt { get; set; }

        /// <summary>
        /// 暂停的入群有礼个数。单位：个数。
        /// </summary>
        [XmlElement("suspend_cnt")]
        public long SuspendCnt { get; set; }

        /// <summary>
        /// 有效的入群有礼个数。单位：个数。
        /// </summary>
        [XmlElement("valid_cnt")]
        public long ValidCnt { get; set; }
    }
}
