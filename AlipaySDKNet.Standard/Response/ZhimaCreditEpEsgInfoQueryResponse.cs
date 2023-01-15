using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEsgInfoQueryResponse.
    /// </summary>
    public class ZhimaCreditEpEsgInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 近12个月内企业是否强制清算或破产
        /// </summary>
        [XmlElement("bankrupt_liquid_12_m_flag")]
        public bool BankruptLiquid12MFlag { get; set; }

        /// <summary>
        /// 近12个月内企业是否存在排污许可证管理失信行为
        /// </summary>
        [XmlElement("emi_licen_ban_num_12_m_flag")]
        public bool EmiLicenBanNum12MFlag { get; set; }

        /// <summary>
        /// 企业处于吊销、注销/拟注销、停歇业状态
        /// </summary>
        [XmlElement("ep_abn_status_flag")]
        public bool EpAbnStatusFlag { get; set; }

        /// <summary>
        /// 近12个月内企业高管变动记录数
        /// </summary>
        [XmlElement("ep_adm_team_adj_num_12_m")]
        public long EpAdmTeamAdjNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业重大税收违法记录数
        /// </summary>
        [XmlElement("ep_big_tax_illegal_num_12_m")]
        public long EpBigTaxIllegalNum12M { get; set; }

        /// <summary>
        /// 截至评价日期，企业最大股东持股占比
        /// </summary>
        [XmlElement("ep_biggest_share_holder_ratio")]
        public string EpBiggestShareHolderRatio { get; set; }

        /// <summary>
        /// 截至评价日期，企业是否存在逾期未结清债券
        /// </summary>
        [XmlElement("ep_bond_default_flag")]
        public bool EpBondDefaultFlag { get; set; }

        /// <summary>
        /// 近12个月内企业债券兑付违约记录数
        /// </summary>
        [XmlElement("ep_bond_defaults_num_12_m")]
        public long EpBondDefaultsNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业新增商标记录数
        /// </summary>
        [XmlElement("ep_brand_add_num_12_m")]
        public long EpBrandAddNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业经营异常记录数
        /// </summary>
        [XmlElement("ep_busi_abnor_num_12_m")]
        public string EpBusiAbnorNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业经营异常最严重类型
        /// </summary>
        [XmlElement("ep_busi_abnor_top_type_12_m")]
        public string EpBusiAbnorTopType12M { get; set; }

        /// <summary>
        /// 近12个月内企业经营范围变更记录数
        /// </summary>
        [XmlElement("ep_busi_scope_adj_num_12_m")]
        public long EpBusiScopeAdjNum12M { get; set; }

        /// <summary>
        /// 企业社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 各类资质证照
        /// </summary>
        [XmlArray("ep_cetificate_list")]
        [XmlArrayItem("string")]
        public List<string> EpCetificateList { get; set; }

        /// <summary>
        /// 近12个月企业子公司是否存在重大风险
        /// </summary>
        [XmlElement("ep_child_risk_12_m_flag")]
        public bool EpChildRisk12MFlag { get; set; }

        /// <summary>
        /// 企业所在行业气候风险暴露程度，枚举值：ABCD
        /// </summary>
        [XmlElement("ep_climate_risk_exp")]
        public string EpClimateRiskExp { get; set; }

        /// <summary>
        /// 企业单位营收二氧化碳排放量行业均值
        /// </summary>
        [XmlElement("ep_co_2_emi_per_rvn")]
        public string EpCo2EmiPerRvn { get; set; }

        /// <summary>
        /// 近12个月内企业新增著作权记录数
        /// </summary>
        [XmlElement("ep_copyright_add_num_12_m")]
        public long EpCopyrightAddNum12M { get; set; }

        /// <summary>
        /// 企业拥有著作权记录数（每万元注册资本）
        /// </summary>
        [XmlElement("ep_copyright_total_num")]
        public string EpCopyrightTotalNum { get; set; }

        /// <summary>
        /// 近12个月内企业贿赂腐败案件被诉记录数(每万元注册资本)
        /// </summary>
        [XmlElement("ep_corrupt_brib_legal_case_num_12_m")]
        public string EpCorruptBribLegalCaseNum12M { get; set; }

        /// <summary>
        /// 近12个月内发生刑事案件被诉次数
        /// </summary>
        [XmlElement("ep_criminal_case_num_12_m")]
        public long EpCriminalCaseNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业债券评级下调记录数
        /// </summary>
        [XmlElement("ep_down_rating_bond_num_12_m")]
        public long EpDownRatingBondNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业发行人主体评级下调记录数
        /// </summary>
        [XmlElement("ep_down_rating_issuer_num_12_m")]
        public long EpDownRatingIssuerNum12M { get; set; }

        /// <summary>
        /// 企业单位营收能源消耗量行业均值
        /// </summary>
        [XmlElement("ep_energy_consume_per_rvn")]
        public string EpEnergyConsumePerRvn { get; set; }

        /// <summary>
        /// 近12个月内企业环境信用评价等级，例如："green","blue","yellow","red"
        /// </summary>
        [XmlElement("ep_env_evaluate_12_m")]
        public string EpEnvEvaluate12M { get; set; }

        /// <summary>
        /// 近12个月内企业环境信用评价变动情况，字典值："1","2","3","-1","-2","-3"
        /// </summary>
        [XmlElement("ep_env_evaluate_adj_12_m")]
        public string EpEnvEvaluateAdj12M { get; set; }

        /// <summary>
        /// 近12个月内企业发生环保案件被诉次数
        /// </summary>
        [XmlElement("ep_env_legal_case_num_12_m")]
        public long EpEnvLegalCaseNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业环境行政处罚罚款总额，单位为元
        /// </summary>
        [XmlElement("ep_env_penalty_amt_12_m")]
        public string EpEnvPenaltyAmt12M { get; set; }

        /// <summary>
        /// 近12个月内企业环境行政处罚次数
        /// </summary>
        [XmlElement("ep_env_penalty_num_12_m")]
        public long EpEnvPenaltyNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业环境行政处罚最严重类型
        /// </summary>
        [XmlElement("ep_env_penalty_top_type_12_m")]
        public string EpEnvPenaltyTopType12M { get; set; }

        /// <summary>
        /// 近12个月内企业因虚假宣传受到行政处罚次数（每万元注册资本）
        /// </summary>
        [XmlElement("ep_fake_prop_penalty_num_12_m")]
        public string EpFakePropPenaltyNum12M { get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [XmlElement("ep_fd")]
        public string EpFd { get; set; }

        /// <summary>
        /// 近12个月内企业消防行政处罚金额
        /// </summary>
        [XmlElement("ep_fire_penalty_amt_12_m")]
        public string EpFirePenaltyAmt12M { get; set; }

        /// <summary>
        /// 近12个月内企业消防行政处罚次数
        /// </summary>
        [XmlElement("ep_fire_penalty_num_12_m")]
        public long EpFirePenaltyNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业消防处罚最严重类型
        /// </summary>
        [XmlElement("ep_fire_penalty_top_type_12_m")]
        public string EpFirePenaltyTopType12M { get; set; }

        /// <summary>
        /// 近12个月内企业被执行记录数
        /// </summary>
        [XmlElement("ep_force_excute_num_12_m")]
        public long EpForceExcuteNum12M { get; set; }

        /// <summary>
        /// 企业注册成立年数
        /// </summary>
        [XmlElement("ep_founding_years")]
        public long EpFoundingYears { get; set; }

        /// <summary>
        /// 企业分组
        /// </summary>
        [XmlElement("ep_group")]
        public string EpGroup { get; set; }

        /// <summary>
        /// 近12个月内企业股东股权冻结/强制转让总额(万元/万股)
        /// </summary>
        [XmlElement("ep_holder_eqty_frez_amt_12_m")]
        public string EpHolderEqtyFrezAmt12M { get; set; }

        /// <summary>
        /// 近12个月内企业股东股权冻结/强制转让记录数
        /// </summary>
        [XmlElement("ep_holder_eqty_frez_num_12_m")]
        public long EpHolderEqtyFrezNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业股东股权冻结/强制转让记录数
        /// </summary>
        [XmlElement("ep_holder_eqty_frez_ratio_12_m")]
        public long EpHolderEqtyFrezRatio12M { get; set; }

        /// <summary>
        /// 近12个月内企业股东股权冻结/强制转让总额占注册资本比例(%)
        /// </summary>
        [XmlElement("ep_holder_eqty_frez_ratio_12_m_new")]
        public string EpHolderEqtyFrezRatio12MNew { get; set; }

        /// <summary>
        /// 近12个月内企业股东出质股权总数额(万元/万股)
        /// </summary>
        [XmlElement("ep_holder_eqty_pledge_amt_12_m")]
        public string EpHolderEqtyPledgeAmt12M { get; set; }

        /// <summary>
        /// 近12个月内企业股东出质股权记录数
        /// </summary>
        [XmlElement("ep_holder_eqty_pledge_num_12_m")]
        public long EpHolderEqtyPledgeNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业股东出质股权总金额占注册资本比例(%)
        /// </summary>
        [XmlElement("ep_holder_eqty_pledge_ratio_12_m")]
        public string EpHolderEqtyPledgeRatio12M { get; set; }

        /// <summary>
        /// 近12个月内企业发生劳动争议、人事争议被诉次数
        /// </summary>
        [XmlElement("ep_hr_legal_case_num_12_m")]
        public long EpHrLegalCaseNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业人社局行政处罚金额，单位为元
        /// </summary>
        [XmlElement("ep_hr_penalty_amt_12_m")]
        public string EpHrPenaltyAmt12M { get; set; }

        /// <summary>
        /// 近12个月内企业人社局行政处罚次数
        /// </summary>
        [XmlElement("ep_hr_penalty_num_12_m")]
        public long EpHrPenaltyNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业人社局处罚最严重类型
        /// </summary>
        [XmlElement("ep_hr_penalty_top_type_12_m")]
        public string EpHrPenaltyTopType12M { get; set; }

        /// <summary>
        /// 近12个月内企业危废行政处罚次数（每万元注册资本）
        /// </summary>
        [XmlElement("ep_hzd_penalty_num_12_m")]
        public string EpHzdPenaltyNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业危废行政处罚最严重类型
        /// </summary>
        [XmlElement("ep_hzd_penalty_top_type_12_m")]
        public string EpHzdPenaltyTopType12M { get; set; }

        /// <summary>
        /// 近12个月内企业新增icp记录数
        /// </summary>
        [XmlElement("ep_icp_add_num_12_m")]
        public long EpIcpAddNum12M { get; set; }

        /// <summary>
        /// 国民经济行业：一级
        /// </summary>
        [XmlElement("ep_industry_lv_1_code")]
        public string EpIndustryLv1Code { get; set; }

        /// <summary>
        /// 国民经济行业：二级
        /// </summary>
        [XmlElement("ep_industry_lv_2_code")]
        public string EpIndustryLv2Code { get; set; }

        /// <summary>
        /// 国民经济行业：三级
        /// </summary>
        [XmlElement("ep_industry_lv_3_code")]
        public string EpIndustryLv3Code { get; set; }

        /// <summary>
        /// 国民经济行业：四级
        /// </summary>
        [XmlElement("ep_industry_lv_4_code")]
        public string EpIndustryLv4Code { get; set; }

        /// <summary>
        /// 近12个月内企业投资人股权变更记录数
        /// </summary>
        [XmlElement("ep_investor_eqty_adj_num_12_m")]
        public long EpInvestorEqtyAdjNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业发生知识产权纠纷被诉次数
        /// </summary>
        [XmlElement("ep_ip_legal_case_num_12_m")]
        public long EpIpLegalCaseNum12M { get; set; }

        /// <summary>
        /// 企业是否披露上一年度年报
        /// </summary>
        [XmlElement("ep_lastyear_ann_rpt_disclose_flag")]
        public bool EpLastyearAnnRptDiscloseFlag { get; set; }

        /// <summary>
        /// 企业最近一期财务报表是否经过审计
        /// </summary>
        [XmlElement("ep_latest_ann_rpt_audit_flag")]
        public bool EpLatestAnnRptAuditFlag { get; set; }

        /// <summary>
        /// 企业最近一期财务报表审计意见类型
        /// </summary>
        [XmlElement("ep_latest_ann_rpt_audit_opinion")]
        public string EpLatestAnnRptAuditOpinion { get; set; }

        /// <summary>
        /// 近12个月内企业法定代表人变更记录数
        /// </summary>
        [XmlElement("ep_legal_person_adj_num_12_m")]
        public long EpLegalPersonAdjNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业失信被执行记录数
        /// </summary>
        [XmlElement("ep_lost_credit_excute_num_12_m")]
        public long EpLostCreditExcuteNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业发生失信历史记录数
        /// </summary>
        [XmlElement("ep_lost_credit_hist_num_12_m")]
        public long EpLostCreditHistNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业母公司是否存在重大风险
        /// </summary>
        [XmlElement("ep_mom_risk_12_m_flag")]
        public bool EpMomRisk12MFlag { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 近12个月内企业合营/联营公司是否存在重大风险
        /// </summary>
        [XmlElement("ep_nephew_risk_12_m_flag")]
        public bool EpNephewRisk12MFlag { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlElement("ep_oprt_scope")]
        public string EpOprtScope { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [XmlElement("ep_org_reg_cptl")]
        public string EpOrgRegCptl { get; set; }

        /// <summary>
        /// 注册资本币种
        /// </summary>
        [XmlElement("ep_org_reg_cptl_curcy")]
        public string EpOrgRegCptlCurcy { get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [XmlElement("ep_org_reg_time")]
        public string EpOrgRegTime { get; set; }

        /// <summary>
        /// 企业经营状态
        /// </summary>
        [XmlElement("ep_org_status")]
        public string EpOrgStatus { get; set; }

        /// <summary>
        /// 近12个月内企业发生其他案由争议被诉次数
        /// </summary>
        [XmlElement("ep_other_legal_case_num_12_m")]
        public string EpOtherLegalCaseNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业其他行政处罚罚款总额
        /// </summary>
        [XmlElement("ep_other_penalty_amt_12_m")]
        public string EpOtherPenaltyAmt12M { get; set; }

        /// <summary>
        /// 近12个月内企业其他行政处罚次数
        /// </summary>
        [XmlElement("ep_other_penalty_num_12_m")]
        public long EpOtherPenaltyNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业其他行政处罚最严重类型
        /// </summary>
        [XmlElement("ep_other_penalty_top_type_12_m")]
        public string EpOtherPenaltyTopType12M { get; set; }

        /// <summary>
        /// 近12个月内企业新增专利记录数
        /// </summary>
        [XmlElement("ep_patent_add_num_12_m")]
        public long EpPatentAddNum12M { get; set; }

        /// <summary>
        /// 企业拥有专利记录数（每万元注册资本）
        /// </summary>
        [XmlElement("ep_patent_total_num")]
        public string EpPatentTotalNum { get; set; }

        /// <summary>
        /// 近12个月内企业涉及民间借贷纠纷案件被诉记录数(每万元注册资本)
        /// </summary>
        [XmlElement("ep_private_lend_legal_case_num_12_m")]
        public string EpPrivateLendLegalCaseNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业产品质量行政处罚金额
        /// </summary>
        [XmlElement("ep_qlty_penalty_amt_12_m")]
        public string EpQltyPenaltyAmt12M { get; set; }

        /// <summary>
        /// 近12个月内企业产品质量行政处罚次数
        /// </summary>
        [XmlElement("ep_qlty_penalty_num_12_m")]
        public long EpQltyPenaltyNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业产品质量处罚最严重类型
        /// </summary>
        [XmlElement("ep_qlty_penalty_top_type_12_m")]
        public string EpQltyPenaltyTopType12M { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("ep_reg_addr")]
        public string EpRegAddr { get; set; }

        /// <summary>
        /// 近12个月内企业注册资本减少比例(%)
        /// </summary>
        [XmlElement("ep_reg_cptl_adj_ratio_12_m")]
        public string EpRegCptlAdjRatio12M { get; set; }

        /// <summary>
        /// 企业所处行业森林、草原、海洋、港口等单一资源的依赖强度，枚举值：ABCD
        /// </summary>
        [XmlElement("ep_resource_other_dependence")]
        public string EpResourceOtherDependence { get; set; }

        /// <summary>
        /// 企业所处行业水资源依赖程度，枚举：ABCD
        /// </summary>
        [XmlElement("ep_resource_water_dependence")]
        public string EpResourceWaterDependence { get; set; }

        /// <summary>
        /// 近12个月内企业实际控制方是否存在重大风险
        /// </summary>
        [XmlElement("ep_root_risk_12_m_flag")]
        public bool EpRootRisk12MFlag { get; set; }

        /// <summary>
        /// 近12个月内企业安监行政处罚罚款总额，单位元
        /// </summary>
        [XmlElement("ep_secu_penalty_amt_12_m")]
        public string EpSecuPenaltyAmt12M { get; set; }

        /// <summary>
        /// 近12个月内企业安监行政处罚次数
        /// </summary>
        [XmlElement("ep_secu_penalty_num_12_m")]
        public long EpSecuPenaltyNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业安监行政处罚最严重类型
        /// </summary>
        [XmlElement("ep_secu_penalty_top_type_12_m")]
        public string EpSecuPenaltyTopType12M { get; set; }

        /// <summary>
        /// 近12个月内企业是否被列入严重违法失信企业名单
        /// </summary>
        [XmlElement("ep_serious_illegal_list_flag")]
        public bool EpSeriousIllegalListFlag { get; set; }

        /// <summary>
        /// 近12个月内企业同一控股股东（包含母公司、实际控制方）控制的其他公司是否存在重大风险
        /// </summary>
        [XmlElement("ep_sibling_risk_12_m_flag")]
        public bool EpSiblingRisk12MFlag { get; set; }

        /// <summary>
        /// 企业单位营收固体废弃物排放量行业均值
        /// </summary>
        [XmlElement("ep_solid_emi_per_rvn")]
        public string EpSolidEmiPerRvn { get; set; }

        /// <summary>
        /// 近12个月内企业员工人数变动率
        /// </summary>
        [XmlElement("ep_staff_num_adj_rate_12_m")]
        public string EpStaffNumAdjRate12M { get; set; }

        /// <summary>
        /// 企业状态
        /// </summary>
        [XmlElement("ep_status")]
        public string EpStatus { get; set; }

        /// <summary>
        /// 近12个月内企业被列为税务非正常户记录数
        /// </summary>
        [XmlElement("ep_tax_abnor_acct_num_12_m")]
        public long EpTaxAbnorAcctNum12M { get; set; }

        /// <summary>
        /// 最新一期企业纳税信用等级变动情况，字典值："a_nota","nota_a","unchg"
        /// </summary>
        [XmlElement("ep_tax_credit_adj_dic_latest")]
        public string EpTaxCreditAdjDicLatest { get; set; }

        /// <summary>
        /// 近12个月内企业税务行政处罚罚款总额，单位元
        /// </summary>
        [XmlElement("ep_tax_penalty_amt_12_m")]
        public string EpTaxPenaltyAmt12M { get; set; }

        /// <summary>
        /// 近12个月内企业税务行政处罚次数
        /// </summary>
        [XmlElement("ep_tax_penalty_num_12_m")]
        public long EpTaxPenaltyNum12M { get; set; }

        /// <summary>
        /// 近12个月内企业税务行政处罚最严重类型
        /// </summary>
        [XmlElement("ep_tax_penalty_top_type_12_m")]
        public string EpTaxPenaltyTopType12M { get; set; }

        /// <summary>
        /// 近12个月内对企业实施共同控制/施加重大影响的投资方是否存在重大风险
        /// </summary>
        [XmlElement("ep_uncle_risk_12_m_flag")]
        public bool EpUncleRisk12MFlag { get; set; }

        /// <summary>
        /// 近12个月内企业不正当竞争案件被诉记录数
        /// </summary>
        [XmlElement("ep_unfair_compt_legal_case_num_12_m")]
        public string EpUnfairComptLegalCaseNum12M { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("evaluate_time")]
        public string EvaluateTime { get; set; }

        /// <summary>
        /// 近12个月内企业是否存在成员被限制高消费
        /// </summary>
        [XmlElement("excu_limi_high_consum_12_m_flag")]
        public bool ExcuLimiHighConsum12MFlag { get; set; }

        /// <summary>
        /// 企业是否曾经发行绿债
        /// </summary>
        [XmlElement("issue_green_bond_flag")]
        public bool IssueGreenBondFlag { get; set; }

        /// <summary>
        /// 上一年度企业是否超标排放废气
        /// </summary>
        [XmlElement("over_std_gas_emi_last_year_flag")]
        public bool OverStdGasEmiLastYearFlag { get; set; }

        /// <summary>
        /// 上一年度企业是否超标排放废水
        /// </summary>
        [XmlElement("over_std_water_emi_last_year_flag")]
        public bool OverStdWaterEmiLastYearFlag { get; set; }

        /// <summary>
        /// 上一年度企业是否超量排放废气
        /// </summary>
        [XmlElement("over_vol_gas_emi_last_year_flag")]
        public bool OverVolGasEmiLastYearFlag { get; set; }

        /// <summary>
        /// 上一年度企业是否超量排放废水
        /// </summary>
        [XmlElement("over_vol_water_emi_last_year_flag")]
        public bool OverVolWaterEmiLastYearFlag { get; set; }

        /// <summary>
        /// 近12个月内企业是否发生欠税
        /// </summary>
        [XmlElement("owing_tax_12_m_flag")]
        public bool OwingTax12MFlag { get; set; }

        /// <summary>
        /// 近12个月内企业是否被下达排污限期整改
        /// </summary>
        [XmlElement("req_emi_adj_12_m_flag")]
        public bool ReqEmiAdj12MFlag { get; set; }

        /// <summary>
        /// 近12个月内企业是否发生税务催缴
        /// </summary>
        [XmlElement("tax_as_pay_12_m_flag")]
        public bool TaxAsPay12MFlag { get; set; }

        /// <summary>
        /// 最新一期企业纳税信用等级是否为A
        /// </summary>
        [XmlElement("tax_credit_a_level_latest_flag")]
        public bool TaxCreditALevelLatestFlag { get; set; }
    }
}
