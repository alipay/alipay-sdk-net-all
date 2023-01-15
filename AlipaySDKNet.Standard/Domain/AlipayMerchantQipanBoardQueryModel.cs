using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanBoardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanBoardQueryModel : AopObject
    {
        /// <summary>
        /// 扩展请求参数，如关系类型、聚合维度
        /// </summary>
        [XmlElement("request_params")]
        public string RequestParams { get; set; }

        /// <summary>
        /// 看板场景，全局唯一 如：用户资产总览、用户资产构成、人群概览
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
