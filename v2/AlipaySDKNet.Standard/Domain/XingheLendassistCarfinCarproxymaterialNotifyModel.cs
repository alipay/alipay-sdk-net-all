using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinCarproxymaterialNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinCarproxymaterialNotifyModel : AopObject
    {
        /// <summary>
        /// 文件信息列表
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("carfin_mortgage_received_file")]
        public List<CarfinMortgageReceivedFile> FileList { get; set; }

        /// <summary>
        /// 星河侧抵押订单号
        /// </summary>
        [XmlElement("mortgage_no")]
        public string MortgageNo { get; set; }

        /// <summary>
        /// 材料回传场景
        /// </summary>
        [XmlElement("notify_scene")]
        public string NotifyScene { get; set; }

        /// <summary>
        /// 外部代理人订单号
        /// </summary>
        [XmlElement("out_proxy_no")]
        public string OutProxyNo { get; set; }
    }
}
