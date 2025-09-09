using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAffinitycardOrderQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAffinitycardOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单实际占用场景额度，单位：元，精确到小数点后2位
        /// </summary>
        [XmlElement("occupy_scene_amount")]
        public string OccupySceneAmount { get; set; }
    }
}
