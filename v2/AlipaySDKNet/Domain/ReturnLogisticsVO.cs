using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReturnLogisticsVO Data Structure.
    /// </summary>
    [Serializable]
    public class ReturnLogisticsVO : AopObject
    {
        /// <summary>
        /// 退货凭证图片列表，用户寄回时上传的图片URL，上限6张
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 用户退货退款上传物流单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 退货说明，用户寄回商品时填写的备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
