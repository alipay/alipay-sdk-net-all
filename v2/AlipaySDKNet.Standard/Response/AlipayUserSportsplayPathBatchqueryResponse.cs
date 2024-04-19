using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSportsplayPathBatchqueryResponse.
    /// </summary>
    public class AlipayUserSportsplayPathBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 路线列表
        /// </summary>
        [XmlElement("response")]
        public WalkPathMetaDataResult Response { get; set; }
    }
}
