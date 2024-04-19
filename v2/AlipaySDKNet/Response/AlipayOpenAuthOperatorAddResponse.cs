using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthOperatorAddResponse.
    /// </summary>
    public class AlipayOpenAuthOperatorAddResponse : AopResponse
    {
        /// <summary>
        /// 关联账号列表
        /// </summary>
        [XmlArray("accounts")]
        [XmlArrayItem("operator_account_v_o")]
        public List<OperatorAccountVO> Accounts { get; set; }

        /// <summary>
        /// 创建的蚂蚁操作员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }
    }
}
