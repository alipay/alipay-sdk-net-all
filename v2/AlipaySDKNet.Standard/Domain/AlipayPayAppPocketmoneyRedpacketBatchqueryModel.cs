using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppPocketmoneyRedpacketBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppPocketmoneyRedpacketBatchqueryModel : AopObject
    {
        /// <summary>
        /// 待查询红包外部单号， 由业务方自定义 ，在支付宝完成红包发送后厂商可根据外部单号查询红包详细信息，数据类型为数组
        /// </summary>
        [XmlArray("red_pocket_out_nos")]
        [XmlArrayItem("string")]
        public List<string> RedPocketOutNos { get; set; }

        /// <summary>
        /// 厂商名称  不在白名单内厂商查询结果报错无查询权限
        /// </summary>
        [XmlElement("vendor_name")]
        public string VendorName { get; set; }
    }
}
