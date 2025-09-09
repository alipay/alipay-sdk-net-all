using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftAssetBatchDestroyResponse.
    /// </summary>
    public class AnttechNftAssetBatchDestroyResponse : AopResponse
    {
        /// <summary>
        /// 成功执行回收的nftid列表数据
        /// </summary>
        [XmlArray("success_nft_list")]
        [XmlArrayItem("string")]
        public List<string> SuccessNftList { get; set; }
    }
}
