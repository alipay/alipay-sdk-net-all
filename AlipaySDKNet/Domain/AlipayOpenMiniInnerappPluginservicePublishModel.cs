using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginservicePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerappPluginservicePublishModel : AopObject
    {
        /// <summary>
        /// 功能类型，目前支持的有：1039支付, 1040会员, 1041基础, 1056资金, 1058信用, 1111口碑, 330120安全, 360101营销
        /// </summary>
        [XmlArray("ability_type_list")]
        [XmlArrayItem("string")]
        public List<string> AbilityTypeList { get; set; }

        /// <summary>
        /// 服务发布logo
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 移动端详情，用于能力中心展示
        /// </summary>
        [XmlElement("detail_for_client")]
        public string DetailForClient { get; set; }

        /// <summary>
        /// pc端详，用于能力中心展示
        /// </summary>
        [XmlElement("detail_for_pc")]
        public string DetailForPc { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 可订购人群，1003个人, 1004企业，-1无限制
        /// </summary>
        [XmlElement("sell_crowd")]
        public string SellCrowd { get; set; }

        /// <summary>
        /// 发布后是否展示，01展示（默认）、02隐藏
        /// </summary>
        [XmlElement("show_type")]
        public string ShowType { get; set; }

        /// <summary>
        /// 服务标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// pc端url地址，不需要则为空
        /// </summary>
        [XmlElement("visit_url_for_pc")]
        public string VisitUrlForPc { get; set; }
    }
}
