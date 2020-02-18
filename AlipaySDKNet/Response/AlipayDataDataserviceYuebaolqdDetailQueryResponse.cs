using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceYuebaolqdDetailQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceYuebaolqdDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 余额宝清算日预测申赎数据
        /// </summary>
        [XmlArray("yeb_ldq_data")]
        [XmlArrayItem("alipay_yeb_lqd_data_result")]
        public List<AlipayYebLqdDataResult> YebLdqData { get; set; }
    }
}
