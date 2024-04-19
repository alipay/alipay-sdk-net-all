using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpBasicinfoAlterSubscribeResponse.
    /// </summary>
    public class ZhimaCreditEpBasicinfoAlterSubscribeResponse : AopResponse
    {
        /// <summary>
        /// 企业基本信息列表
        /// </summary>
        [XmlArray("ep_basic_infos")]
        [XmlArrayItem("ep_basic_info")]
        public List<EpBasicInfo> EpBasicInfos { get; set; }

        /// <summary>
        /// 监听项列表
        /// </summary>
        [XmlArray("listen_item_list")]
        [XmlArrayItem("string")]
        public List<string> ListenItemList { get; set; }

        /// <summary>
        /// 唯一的监听订单号，后续可应用于订阅取消
        /// </summary>
        [XmlElement("listen_no")]
        public string ListenNo { get; set; }
    }
}
