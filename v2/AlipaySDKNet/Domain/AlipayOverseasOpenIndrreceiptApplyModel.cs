using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndrreceiptApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndrreceiptApplyModel : AopObject
    {
        /// <summary>
        /// 凭证申请参数列表
        /// </summary>
        [XmlArray("apply_receipt_list")]
        [XmlArrayItem("indr_i_s_v_receipt_apply_d_t_o")]
        public List<IndrISVReceiptApplyDTO> ApplyReceiptList { get; set; }

        /// <summary>
        /// C2B业务场景枚举值，HOUSE_RENTAL租房场景，TUITION留学场景
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
