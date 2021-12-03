using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundBailCollectionFinishResponse.
    /// </summary>
    public class AlipayFundBailCollectionFinishResponse : AopResponse
    {
        /// <summary>
        /// 当result_code为FAIL时，对应的错误码
        /// </summary>
        [XmlElement("biz_error")]
        public string BizError { get; set; }

        /// <summary>
        /// 支付宝内部委托单号，根据外部委托号out_collection_no查询，仅当存在对应委托单时返回
        /// </summary>
        [XmlElement("collection_no")]
        public string CollectionNo { get; set; }

        /// <summary>
        /// 业务扩展参数，json格式
        /// </summary>
        [XmlElement("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 外部委托号
        /// </summary>
        [XmlElement("out_collection_no")]
        public string OutCollectionNo { get; set; }

        /// <summary>
        /// 销售产品码，用于接入保证金业务，本字段取值固定为BAIL_AUTH
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 处理结果码。处理成功：SUCCESS，处理失败：FAIL
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
