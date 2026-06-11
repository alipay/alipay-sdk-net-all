using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinStatusNotifyOther Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinStatusNotifyOther : AopObject
    {
        /// <summary>
        /// 是否事故车
        /// </summary>
        [XmlElement("accident_vehicle_flag")]
        public bool AccidentVehicleFlag { get; set; }

        /// <summary>
        /// 终审未提报原因码值
        /// </summary>
        [XmlElement("approve_not_submit_code")]
        public string ApproveNotSubmitCode { get; set; }

        /// <summary>
        /// 终审未提交原因描述
        /// </summary>
        [XmlElement("approve_not_submit_msg")]
        public string ApproveNotSubmitMsg { get; set; }

        /// <summary>
        /// 客户等级
        /// </summary>
        [XmlElement("customer_credit_rating")]
        public string CustomerCreditRating { get; set; }

        /// <summary>
        /// 融担机构信息列表
        /// </summary>
        [XmlArray("guarantee_org_list")]
        [XmlArrayItem("carfin_guarantee_inst")]
        public List<CarfinGuaranteeInst> GuaranteeOrgList { get; set; }

        /// <summary>
        /// 是否安装GPS
        /// </summary>
        [XmlElement("needs_gps_installation")]
        public bool NeedsGpsInstallation { get; set; }

        /// <summary>
        /// 机构车辆估值
        /// </summary>
        [XmlElement("org_vehicle_valuation")]
        public long OrgVehicleValuation { get; set; }

        /// <summary>
        /// 购车方式
        /// </summary>
        [XmlElement("pay_method")]
        public string PayMethod { get; set; }
    }
}
