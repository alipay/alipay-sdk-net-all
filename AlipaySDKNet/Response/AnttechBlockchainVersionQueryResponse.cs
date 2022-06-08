using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainVersionQueryResponse.
    /// </summary>
    public class AnttechBlockchainVersionQueryResponse : AopResponse
    {
        /// <summary>
        /// 橡实平台版本信息对象集合
        /// </summary>
        [XmlArray("iteration_version_info_deliver_obj_list")]
        [XmlArrayItem("iteration_version_info_deliver_obj")]
        public List<IterationVersionInfoDeliverObj> IterationVersionInfoDeliverObjList { get; set; }
    }
}
