using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiFqqrcodeLogisticsQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiFqqrcodeLogisticsQueryResponse : AopResponse
    {
        /// <summary>
        /// 承接物料运输订单的快递公司名称
        /// </summary>
        [XmlElement("express_company_name")]
        public string ExpressCompanyName { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 物料订单当前状态."配送指令已下达未拉取"表示正在生产,待揽收;"揽收完成"标识物流公司已经完成揽收;"配送中"表示物流正在运输或物流已结束.
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
