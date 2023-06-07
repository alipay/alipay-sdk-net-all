using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandBrandAssetUnbindResponse.
    /// </summary>
    public class AntMerchantExpandBrandAssetUnbindResponse : AopResponse
    {
        /// <summary>
        /// 操作失败的资产ID集合
        /// </summary>
        [XmlArray("fail_asset_ids")]
        [XmlArrayItem("string")]
        public List<string> FailAssetIds { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_msg")]
        public string FailMsg { get; set; }

        /// <summary>
        /// 操作结果，全部资产操作成功返回true，有一个资产失败则返回false，失败资产和原因见fail_asset_ids和fail_msg
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
