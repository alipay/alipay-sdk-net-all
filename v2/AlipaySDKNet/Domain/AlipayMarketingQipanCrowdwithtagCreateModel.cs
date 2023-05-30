using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingQipanCrowdwithtagCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingQipanCrowdwithtagCreateModel : AopObject
    {
        /// <summary>
        /// 安全应用范围，参考文档 <a href="https://opendocs.alipay.com/pre-open/04phhq" target="_blank">安全应用范围枚举</a>
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 棋盘商家人群描述
        /// </summary>
        [XmlElement("crowd_desc")]
        public string CrowdDesc { get; set; }

        /// <summary>
        /// 人群id，人群加工必选
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 商家棋盘人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 人群在支付宝棋盘站点是否可见,取值如下： <li>true-支付宝站点<b>不可见</b></li> <li>false-支付宝站点<b>可见，默认值</b></li> 使用说明：创建的人群后续需使用标签进行二次圈选，且本人群对商户不可见时可设置为true。
        /// </summary>
        [XmlElement("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// 人群标签值列表
        /// </summary>
        [XmlArray("select_tag_list")]
        [XmlArrayItem("crowd_select_tag_open_request")]
        public List<CrowdSelectTagOpenRequest> SelectTagList { get; set; }
    }
}
