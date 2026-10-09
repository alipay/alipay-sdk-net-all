using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradePayeeReceivableQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradePayeeReceivableQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景，由网商端指定
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 是否针对应收咨询保理业务，为true的话耗时会较长
        /// </summary>
        [XmlElement("need_factoring_consult")]
        public bool NeedFactoringConsult { get; set; }

        /// <summary>
        /// 根据网商订单号查询，与其它过滤条件为且的关系
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("string")]
        public List<string> OrderList { get; set; }

        /// <summary>
        /// 根据平台方订单号查询，与其它过滤条件为且的关系。
        /// </summary>
        [XmlArray("platform_order_list")]
        [XmlArrayItem("string")]
        public List<string> PlatformOrderList { get; set; }

        /// <summary>
        /// 查询状态列表，入参为空表示全部查询，与其它过滤条件为且的关系
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// 子场景，可空
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 用户信息--必选
        /// </summary>
        [XmlElement("user_info")]
        public CreditPayUserVO UserInfo { get; set; }
    }
}
