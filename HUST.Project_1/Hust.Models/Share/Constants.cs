namespace Hust.Models.Share
{
    public static class Constants
    {
        public static class Config
        {
            /// <summary>
            /// Items per page default
            /// </summary>
            public const int ITEMS_PER_PAGE = 20;

            /// <summary>
            /// Shift start type
            /// </summary>
            public const string SHIFT_START_TYPE = "ShiftStart";

            /// <summary>
            /// Shift end type
            /// </summary>
            public const string SHIFT_END_TYPE = "ShiftEnd";

            /// <summary>
            /// Image default base 64
            /// </summary>
            public const string IMAGE_DEFAULT_BASE64 = "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";

            /// <summary>
            /// Items per page default
            /// </summary>
            public const int ITEMS_TOP_NOTIFICATION = 10;

            /// <summary>
            /// Email Template
            /// </summary>
            public class EmailTemplate
            {
                public const string ADMIN_TRANSFER_MOC = "EmailTemplate_AdminTransferMOCApprover";
                public const string ADMIN_CANCEL_MOC = "EmailTemplate_AdminCancelMOC";
                public const string APPLICANT_CANCEL_MOC = "";
                public const string MOC_REQUIRES_UPDATE = "EmailTemplate_MOCRequireUpdate";
                public const string MOC_APPROVED = "EmailTemplate_MOCApproved";
                public const string MOC_PENDING_APPROVAL = "EmailTemplate_PendingMocApproval";
                //todo
                public const string RA_APPROVED = "EmailTemplate_RAApproverApprove";
                /// <summary>
                /// Email Template for RA Update Required
                /// </summary>
                public const string RA_UPDATE_REQUIRED = "EmailTemplate_RAUpdateRequired";
                /// <summary>
                /// Email Template for RA Endorse
                /// </summary>
                public const string RA_PENDING_APPROVE = "EmailTemplate_RAApprove";
                /// <summary>
                /// Email Template For RA Endorse
                /// </summary>
                public const string RA_PENDING_ENDORSE = "EmailTemplate_RAEndorse";
                /// <summary>
                /// Email Template RA Review
                /// </summary>
                public const string RA_PENDING_REVIEW = "EmailTemplate_RAReview";
                /// <summary>
                ///  Email Template SCE
                /// </summary>
                public const string SCE = "EmailTemplate_SCE";
                /// <summary>
                /// Email Template SCE Review
                /// </summary>
                public const string SCE_REVIEW = "EmailTemplate_SCEReview";
                /// <summary>
                ///
                /// </summary>
                public const string SCE_REVIEW_REJECT = "EmailTemplate_SCEUpdateRequired";
                /// <summary>
                /// Email Template SCE Approve
                /// </summary>
                public const string SCE_APPROVE = "EmailTemplate_SCEApprove";
                /// <summary>
                ///
                /// </summary>
                public const string SCE_APPOVE_REJECT = "EmailTemplate_SCEUpdateRequired";
                /// <summary>
                /// Email Template SCE Endorse
                /// </summary>
                public const string SCE_ENDORSE = "EmailTemplate_SCEEndorse";
                /// <summary>
                ///
                /// </summary>
                public const string SCE_ENDORSE_REJECT = "EmailTemplate_SCEUpdateRequired";
                /// <summary>
                /// Email Template SCE Transfer
                /// </summary>
                public const string SCE_TRANSFER = "EmailTemplate_SCETransfer";
                /// <summary>
                /// Email Template RA Transfer
                /// </summary>
                public const string RA_TRANSFER = "EmailTemplate_RATransfer";
                /// <summary>
                /// Email Template SCE Acknowledge
                /// </summary>
                public const string SCE_ACKNOWLEDGE = "EmailTemplate_SCEAcknowledge";
                /// <summary>
                /// Email Template SCE Live
                /// </summary>
                public const string SCE_LIVE = "EmailTemplate_SCELive";
                /// <summary>
                /// Email Template SCE ReApprove
                /// </summary>
                public const string SCE_REAPPROVE = "EmailTemplate_SCEReApprove";
            }

        }

        public static class EmailAction
        {
            public const string MOC_CANCEL = "Moc Cancel";
            public const string MOC_REQUIRES_UPDATE = "MOC requires update";
            public const string MOC_APPROVE = "MOC Approve";
            public const string RA_UPDATE_REQUIRED = "Update Required";
            public const string RA_APPROVE = "Approve";
            public const string RA_ENDORSE = "Endorse";
            public const string RA_REVIEW = "Review";
            public const string REJECT = "Reject";
            public const string SCE_CREATE = "Create";
            public const string SCE_REVIEW = "Review";
            public const string SCE_ENDORSE = "Endorse";
            public const string SCE_APPROVE = "Approve";
            public const string SCE_RE_APPROVE = "Re-Approve";
            public const string SCE_ACKNOWLEDGE = "Acknowledge";
            public const string SCE_RE_ACKNOWLEDGE = "Re-Acknowledge";
            public const string SCE_LIVE = "Live";
            public const string SCE_NORMALIZE = "Normalize";
            public const string SCE_TRANSFER = "Transfer";
            public const string SCE_UPDATE_REQUIRED = "Update Required";
        }

        public static class EmailLink
        {
            public const string RA_DETAIL = "radetail";
            public const string RA_UPDATE_REQUIRED = "raupdaterequired";
            public const string RA_APPROVE = "raapprove";
            public const string RA_ENDORSE = "raendorse";
            public const string RA_REVIEW = "rareview";
            public const string SCE_REVIEW = "sce_review";
            public const string SCE_ENDORSE = "sce_endorse";
            public const string SCE_APPROVE = "sce_approve";
            public const string SCE_ACKNOWLEDGE = "sce_acknowledge";
            public const string SCE_REQUIRE_UPDATE = "sce_update_require";
            public const string SCE_DETAIL = "sce_detail";
            public const string SCE_LIVE = "sce_live";
        }

        public static class ImpactGroup
        {
            public const string PEOPLE = "People";
            public const string ENVIRONMENT = "Environment";
            public const string ASSET = "Asset";
            public const string REPUTATION = "Reputation";
        }

        public static class ParameterEmail
        {
            public const string FROM_USER = "From_User";
            public const string USER_NAME = "UserName";
            public const string RA_NO = "RA_NO";
            public const string SCE_NO = "SCE_NO";
            public const string ACTION = "Action";
            public const string REASON = "Reason";
            public const string HERE = "here";
            public const string TAG_NO = "TagNo";
        }

        public static class Role
        {
            /// <summary>
            /// SCE Requestor Role
            /// </summary>
            public const string APPLICANT = "1";
            /// <summary>
            /// SCE Reviewer Role
            /// </summary>
            public const string SCE_REVIEWER = "2";
            /// <summary>
            /// SCE Endorser Role
            /// </summary>
            public const string SCE_ENDORSER = "3";
            /// <summary>
            /// SCE Approver Role
            /// </summary>
            public const string SCE_APPROVER = "4";
            /// <summary>
            /// SCE Acknowledger Role
            /// </summary>
            public const string SCE_ACKNOWLEDGER = "5";
            /// <summary>
            /// SCE Admin Role
            /// </summary>
            public const string ADMINISTRATOR = "0";
            /// <summary>
            /// SCE User Role
            /// </summary>
            public const string SCE_USER = "7";
            /// <summary>
            /// RA Reviewer
            /// </summary>
            public const string RA_REVIEWER = "9";
            /// <summary>
            /// RA Endorser
            /// </summary>
            public const string RA_ENDORSER = "10";
            /// <summary>
            /// RA Approver
            /// </summary>
            public const string RA_APPROVER = "11";
            /// <summary>
            /// RA Acknowledger
            /// </summary>
            public const string RA_ACKNOWLEDGER = "12";
            /// <summary>
            /// RA User
            /// </summary>
            public const string RA_USER = "14";
            /// <summary>
            /// MOC Approver
            /// </summary>
            public const string MOC_APPROVER = "15";
        }

        public static class RoleName
        {
            /// <summary>
            /// SCE Requestor Role
            /// </summary>
            public const string APPLICANT = "Applicant";
            /// <summary>
            /// SCE Reviewer Role
            /// </summary>
            public const string SCE_REVIEWER = "SCE Reviewer";
            /// <summary>
            /// SCE Endorser Role
            /// </summary>
            public const string SCE_ENDORSER = "SCE Endorser";
            /// <summary>
            /// SCE Approver Role
            /// </summary>
            public const string SCE_APPROVER = "SCE Approver";
            /// <summary>
            /// SCE Acknowledger Role
            /// </summary>
            public const string SCE_ACKNOWLEDGER = "SCE Acknowledger";
            /// <summary>
            /// SCE Admin Role
            /// </summary>
            public const string ADMINISTRATOR = "Administrator";
            /// <summary>
            /// SCE User Role
            /// </summary>
            public const string SCE_USER = "SCE User";
            /// <summary>
            /// RA Reviewer
            /// </summary>
            public const string RA_REVIEWER = "RA Facilitator";
            /// <summary>
            /// RA Endorser
            /// </summary>
            public const string RA_ENDORSER = "RA Endorser";
            /// <summary>
            /// RA Approver
            /// </summary>
            public const string RA_APPROVER = "RA Approver";
            /// <summary>
            /// RA Acknowledger
            /// </summary>
            public const string RA_ACKNOWLEDGER = "RA Acknowledger";
            /// <summary>
            /// RA User
            /// </summary>
            public const string RA_USER = "RA User";
            /// <summary>
            /// MOC Approver
            /// </summary>
            public const string MOC_APPROVER = "MOC Approver";
        }

        public static class StoredProcedure
        {
            public const string CHECK_USER_HAS_ROLE_KEY = "sp_UserProfile_CheckUserHasRoleKey";
            public const string CHECK_IS_APPLICANT_IN_AREA = "sp_UserProfile_CheckIsApplicantInArea";
            public const string GET_USERS_BY_ROLE_KEY_IN_AREA = "sp_GetUsersByRoleKeyInArea";
            public const string GET_TAG_NO_BY_SCE_ID = "sp_GetTagNoBySceId";
            public const string GET_APPLICANT = "sp_GetApplicant";
            public const string SCE_GET_PENDING_PERSON = "sp_SCE_GetPendingPeopleForTransferingRoles";
            public const string RA_GET_PENDING_PERSON = "sp_RA_GetPendingPersonProfileId";
            public const string COUNT_RISK_LEVEL = "sp_Lookup_Risk_CountRiskLevel";
            public const string GET_PERSON_INCHARGE = "sp_SCE_GetPersonInCharge";
            public const string CHECK_PEOPLE_INCHARGE = "sp_CheckPeopleInCharge";
            public const string CHECK_RA_PEOPLE_INCHARGE = "sp_CheckRAPeopleInCharge";
            public const string GET_SUBSCRIBED_AREAS = "sp_GetSubscribedAreas";
            public const string GET_RA_BASIC = "sp_GetRABasic";
            public const string GET_LIKELIHOOD = "sp_GetLikelihood";
            public const string GET_SEVERITY = "sp_GetSeverity";
            public const string GET_RISK_ID = "sp_GetRiskId";
            public const string GET_SEVERITIES_BY_IMPACT_GROUP = "sp_GetSeveritiesByGroup";
            public const string GET_RA_INITIAL_DATA = "sp_RAGetInitialData";
            public const string GET_ACTIVE_AREAS = "sp_GetActiveAreas";
            public const string CHECK_PTW_EDITABLE = "sp_CheckPTWEditable";
            public const string CHECK_RA_APPLICANT = "sp_CheckRAApplicant";
            /// <summary>
            /// Stored Procedure insert risk assessment logs
            /// </summary>
            public const string INSERT_STATUS_LOG = "sp_InsertStatusLog";
            /// <summary>
            /// Stored Procedure get sce status log
            /// </summary>
            public const string GET_SCE_STATUS_LOG = "sp_LogStatus_GetSCELogs";
            /// <summary>
            /// Stored Procedure get sce status log
            /// </summary>
            public const string GET_RA_STATUS_LOG = "sp_LogStatus_GetRaLogs";
            /// <summary>
            /// Stored Procedure get risk assessment listing
            /// </summary>
            public const string GET_RA_LISTING = "sp_RA_GetListing";
            /// <summary>
            /// Stored Procedure get My risk assessment listing
            /// </summary>
            public const string GET_TOTAL_MY_RA_LISTING = "sp_RA_GetTotalMyRaListing";

            /// <summary>
            /// Stored Procedure get people incharge for risk assessment form
            /// </summary>
            public const string GET_PEOPLE_IN_CHARGE = "sp_GetPeopleIncharge";
            /// <summary>
            /// Stored Procedure Get Team Members in risk assessment form
            /// </summary>
            public const string GET_TEAM_MEMBERS = "sp_GetTeamMembers";
            /// <summary>
            /// Stored Procedure Get detail information of ra form
            /// </summary>
            public const string GET_RA_DETAIL = "sp_GetRADetail";
            /// <summary>
            /// Stored Procedure Ra Get Info RA Copy
            /// </summary>
            public const string GET_INFO_RA_COPY = "sp_RA_GetInfoRaCopy";
            /// <summary>
            /// Stored Procedure Get Users By Rolekey
            /// </summary>
            public const string SP_GET_USERS_BY_ROLE_KEY = "sp_GetUsersByRoleKey";
            /// <summary>
            /// Stored Procedure login
            /// </summary>
            public const string SP_LOGIN = "sp_login";
            /// <summary>
            /// Stored Procedure Get Active User View
            /// </summary>
            public const string SP_GET_ACTIVE_USERS_VIEW = "sp_GetActiveUserView";
            /// <summary>
            /// Stored Procedure Get Info User By Token
            /// </summary>
            public const string SP_INFO_USER_BY_TOKEN = "sp_GetInfoUserByToken";
            /// <summary>
            /// Stored Procedure Refresh Token
            /// </summary>
            public const string SP_REFRESH_TOKEN = "sp_RefreshToken";
            /// <summary>
            /// Stored Procedure Get Access Permission
            /// </summary>
            public const string SP_GET_ACCESS_PERMISSION = "sp_GetAccessPermission";
            /// <summary>
            /// Stored Procedure Schedule Sce ReApproval
            /// </summary>
            public const string SCHEDULE_SCE_RE_APPROVAL = "sp_Schedule_SceReApproval";
            /// <summary>
            /// Stored Procedure Schedule Sce Change Shift
            /// </summary>
            public const string SCHEDULE_SCE_CHANGE_SHIFT = "sp_Schedule_SceChangeShift";
            /// <summary>
            /// Stored Procedure Get List User
            /// </summary>
            public const string GET_USER_LIST = "sp_User_GetList";
            /// <summary>
            /// Stored Procedure Get Get All Role Include Number User
            /// </summary>
            public const string GET_ROLE_GET_ALL_ROLE_INCLUDE_NUMBER_USER = "sp_Role_GetAllRoleIncludeNumberUser";
            /// <summary>
            /// Stored Procedure Get Roles Include Module
            /// </summary>
            public const string GET_ROLES_INCLUDE_MODULE = "sp_Role_GetRolesIncludeModule";
            /// <summary>
            /// Stored Procedure Get Module Access By UserProfileId
            /// </summary>
            public const string GET_MODULE_ACCESS_BY_USER_PROFILE_ID = "sp_ModuleAccess_GetModuleAccessByUserProfileId";
            /// <summary>
            /// Stored Procedure Get UserProfileId, Email, ModuleStageKey, Token By sceId (optional: sceModuleStageKey, areaId)
            /// </summary>
            public const string SCE_GET_USERS_IN_CURRENT_WORK_FLOW_BY_SCE_ID = "sp_SCE_GetUsersInCurrentWorkFlowBySceId";
            /// <summary>
            /// Stored Procedure Get UserProfileId, Email, ModuleStageKey, Token By sceId (optional: sceModuleStageKey, areaId)
            /// </summary>
            public const string RA_GET_USERS_IN_CURRENT_WORK_FLOW_BY_RA_ID = "sp_RA_GetUsersInCurrentWorkFlowByRaId";

            #region Messages
            /// <summary>
            /// Stored Procedure Get List Messages
            /// </summary>
            public const string GET_LIST_MESSAGES = "sp_Messages_GetListMessages";
            /// <summary>
            /// Stored Procedure Get List Messages Admin
            /// </summary>
            public const string GET_LIST_MESSAGES_ADMIN = "sp_Messages_GetListMessagesAdmin";
            /// <summary>
            /// Stored Procedure Get List Of Area Messages Admin
            /// </summary>
            public const string GET_LIST_OF_AREA = "sp_Messages_GetListOfArea";
            #endregion

            #region SCE

            /// <summary>
            /// Stored Procedure Get SCE Dashboard
            /// </summary>
            public const string GET_SCE_DASHBOARD = "sp_GetSCEDashBoard";

            /// <summary>
            /// Stored Procedure Get Sce For Sce DashBoard
            /// </summary>
            public const string GET_SCE_FOR_SCE_DASHBOARD = "sp_SCE_GetSceForSceDashBoard";

            /// <summary>
            /// Stored Procedure Get Sce Pending Action For Sce DashBoard
            /// </summary>
            public const string GET_SCE_PENDING_ACTION_FOR_SCE_DASHBOARD = "sp_SCE_GetScePendingActionForSceDashBoard";

            /// <summary>
            /// Stored Procedure Get RA Pending Action For Sce DashBoard
            /// </summary>
            public const string GET_RA_PENDING_ACTION_FOR_SCE_DASHBOARD = "sp_RA_GetRaPendingActionForSceDashBoard";

            /// <summary>
            /// Stored Procedure get SCE listing
            /// </summary>
            public const string GET_SCE_LISTING = "sp_SCE_GetListing";
            /// <summary>
            /// Get Total My Sce Listing
            /// </summary>
            public const string GET_TOTAL_MY_SCE_LISTING = "sp_SCE_GetTotalMySceListing";

            /// <summary>
            /// Stored Procedure Get SCE Detail
            /// </summary>
            public const string GET_SCE_DETAIL = "sp_SCE_GetDetail";

            /// <summary>
            /// Stored procedure Get SCE Copied
            /// </summary>
            public const string GET_SCE_COPY = "sp_SCE_Copy";

            /// <summary>
            /// Stored Procedure Get SCE Printing Detail
            /// </summary>
            public const string GET_SCE_PRINTING_DETAIL = "sp_SCE_GetPrintingDetail";

            /// <summary>
            /// Store Procedure GET SCE Ext History
            /// </summary>
            public const string GET_SCE_EXT_HISTORY = "sp_SceExt_GetHistory";

            /// <summary>
            /// Stored Procedure Get SceExt By SceId
            /// </summary>
            public const string GET_SCE_EXT_BY_SCE_ID = "sp_SCE_GetExtApprovalBySceIdWithPaging";

            /// <summary>
            /// Strored Procedure Get top SceExt by SceId
            /// </summary>
            public const string GET_TOP_SCE_EXT_BY_SCE_ID = "sp_SCE_GetTopExtApprovalBySceId";

            /// <summary>
            /// Stored Procedure GET SCE ACKNOWLEDGE HISTORY
            /// </summary>
            public const string GET_SCE_ACKNOWLEDGE_HISTORY = "sp_SceAcknowledge_GetHistory";

            /// <summary>
            /// Stored Procedure GET SCE RE-ACKNOWLEDGE BY SCE ID
            /// </summary>
            public const string GET_SCE_RE_ACKNOWLEDGE_BY_SCE_ID = "sp_SCE_GetAcknowledgeBySceIdWithPaging";

            /// <summary>
            /// Stored Procedure GET TOP SCE RE-ACKNOWLEDGE BY SCE ID
            /// </summary>
            public const string GET_TOP_SCE_RE_ACKNOWLEDGE_BY_SCE_ID = "sp_SCE_GetTopAcknowledgeBySceId";

            /// <summary>
            /// Stored Procedure Get SCE PTW Listing
            /// </summary>
            public const string GET_SCE_PTW_LISTING = "sp_GetSCEPTWListing";

            /// <summary>
            /// Stored Procedure Get  PTW by SCE ID
            /// </summary>
            public const string GET_PTW_BY_SCE_ID = "sp_PTW_GetBySceId";

            /// <summary>
            /// Stored Procedure Get Monthly SCE Live Statistic
            /// </summary>
            public const string GET_MONTHLY_SCE_LIVE_STATISTIC = "sp_SCE_GetMonthlyStatisticSCELIVE";

            #endregion

            #region Notification

            /// <summary>
            /// Stored Procedure get Notification listing
            /// </summary>
            public const string GET_NOTIFICATION_LISTING = "sp_Notification_GetListing";
            /// Stored Procedure get Notification listing 4 Lastest
            public const string GET_NOTIFICATION_LISTING_4_LASTEST = "sp_Notification_GetListing_5_Lastest";

            #endregion

            #region UserProfile

            /// <summary>
            /// Stored Procedure get user by id and status
            /// </summary>
            public const string GET_USER_BY_ID_AND_STATUS = "sp_UserProfile_GetUserByIdAndStatus";

            #endregion

            #region Files
            /// <summary>
            /// Stored Procedure Get File By ReferenceId
            /// </summary>
            public const string GET_FILE_BY_REFERENCE_ID = "sp_Files_GetFileByReferenceId";
            /// <summary>
            /// Stored Procedure Delete files
            /// </summary>
            public const string FILE_DELETE_FILES = "sp_Files_DeleteFiles";
            /// <summary>
            /// Stored Procedure Active files
            /// </summary>
            public const string FILE_ACTIVE_FILES = "sp_Files_ActiveFiles";
            #endregion

            #region Email Notification
            /// <summary>
            /// Stored Procedure Get list Email Enable email notification
            /// </summary>
            public const string GET_LIST_EMAIL_ENABLE_EMAIL_NOTIFICATION = "sp_EmailNotification_GetListEmailEnableEmailNotification";
            #endregion
        }

        public static class Status
        {
            public const string SCE_DRAFT_OR_REQUEST = "1";
            public const string SCE_PENDING_REVIEW = "2";
            public const string SCE_PENDING_ENDORSE = "3";
            public const string SCE_PENDING_APPROVAL = "4";
            public const string SCE_PENDING_ACKNOWLEDGEMENT = "5";
            public const string SCE_PENDING_RE_ACKNOWLEDGEMENT = "6";
            public const string SCE_LIVE = "7";
            public const string SCE_PENDING_MOC = "8";
            public const string SCE_UPDATE_REQUIRED = "9";
            public const string SCE_NORMALIZE = "10";
            public const string RA_DRAFT_OR_REQUEST = "11";
            public const string RA_PENDING_REVIEW = "12";
            public const string RA_PENDING_ENDORSE = "13";
            public const string RA_PENDING_APPROVAL = "14";
            public const string RA_PENDING_ACKNOWLEDGEMENT = "15";
            public const string RA_PENDING_RE_ACKNOWLEDGEMENT = "16";
            public const string RA_ACKNOWLEDGE = "16";
            public const string RA_PENDING_MOC = "18";
            public const string RA_UPDATE_REQUIRED = "19";
            public const string RA_APPROVED = "20";
        }

        public static class MocStatus
        {
            public const int NOT_REQUIRED = 0;
            public const int PENDING_MOC = 1;
            public const int PENDING_MOC_APPROVAL = 2;
            public const int REQUIRES_UPDATE = 3;
            public const int MOC = 4;
        }

        public static class ModuleDescription
        {
            public const string SCE = "SCE";
            public const string RA = "RA";
        }

        public static class ModuleStageKey
        {
            public const string INITIATE = "1";
            public const string SCE_REVIEW = "2";
            public const string SCE_ENDORSE = "3";
            public const string SCE_APPROVE = "4";
            public const string SCE_ACKNOWLEDGE = "5";
            public const string SCE_LIVE = "6";
            public const string SCE_NORMALIZE = "7";
            public const string RA_REVIEW = "8";
            public const string RA_ENDORSE = "9";
            public const string RA_APPROVAL = "10";
            public const string RA_ACKNOWLEDGE = "11";
            public const string MOC = "14";
        }

        public static class Message
        {
            public const string MOC_CANCELLED = "This MOC is cancelled.";
            public const string MOC_REJECTED = "this MOC is not approved and requires update from the applicant.";
            public const string MOC_APPROVED = "This MOC is approved";
            public const string RA_HAS_NOT_APPROVED = "This RA form has not been approved";
            public const string MESSAGE_REQUIRED = "{0} is required when you submit this form to reviewer";
            public const string TRANSFER_ROLES_SUCCESSFULLY = "You have been transferred roles successfully";
            public const string PTW_REQUIRED = "You need at least one PTW number to normalized";
            public const string ROLE_NOT_ALLOW = "You are not {0}. This action is not allowed. Please contact to administrator";
            public const string MOC_UPDATED = "This MOC is updated.";
            public const string RA_NOT_EXISTS = "This RA form do not exist";
            public const string SCE_NORMALIZED = "This SCE has been normalized";
            public const string SCE_DRAFT = "This SCE has not submitted to review yet";
            public const string SCE_HAS_BEEN_CANCELED = "This SCE has been canceled";
            public const string SCE_NOT_EXIST = "This SCE is not exist";
            public const string RA_APPROVE_REJECTED = "This RA is not approved and requires update from the applicant";
            public const string RA_APPROVE_APPROVED = "This RA is approved and pending acknowledgemen.";
            public const string RA_ENDORSE_REJECTED = "This RA is not endorsed and requires update from the applicant";
            public const string RA_ENDORSE_APPROVED = "This RA is endorsed and pending approval.";
            public const string RA_REVIEW_REJECTED = "This RA is not reviewed and requires update from the applicant";
            public const string RA_REVIEW_APPROVED = "This RA is reviewed and pending endorsement.";
            public const string RA_CANCELED_SUCCESSFULLY = "This RA is canceled";
            public const string PTW_DELETED_SUCESSFULLY = "PTW number has been deleted";
            public const string PTW_ADDED_SUCCESSFULLY = "PTW number has been added to database";
            public const string GET_DATA_SUCCESSFULLY = "Data obtained";
            public const string DATA_EMPTY = "Data is empty";
            public const string RA_EXISTED = "Risk Assessment form already exist";
            public const string RA_SUBMITED_FAIL = "Cannot submit Risk Assessment form";
            public const string RA_SAVED_DRAFT_FAIL = "Cannot save Risk Assessment form as draft";
            public const string RA_SAVED_DRAFT_SUCCESSFULLY = "Risk Assessment form saved as draft";
            public const string UPDATED_SUCCESSFUL = "Updated Successful";
            public const string CREATE_SUCCESSFUL = "Create Successful";
            public const string DELETE_SUCCESSFUL = "Delete Successful";
            public const string RA_SUBMITED_SUCCESSFULLY = "Risk Assessment form submitted for review";
            public const string ACTION_NOT_SUPPORTED = "Action is not supported";
            public const string DATA_NOT_VALID = "Data is not valid";
            public const string TOKEN_INVALID = "Token is not valid";
            public const string USER_DOES_NOT_EXIST = "User does not exist";
            public const string ERROR = "An error occured while processing";
            public const string FORBIDDEN = "You are not allowed to perform this action. Please contact the administrator";
            public const string NOT_FOUND = "Data not found";
            public const string PARAMETER_NOT_VALID = "Parameter is not valid";
            public const string INSERT_UNSUCCESSFULL = "Insert data unsuccessful";
            public const string PERMISSION_DENIED = "You do not have permission to perform this action";
            public const string USER_ALREADY_EXIST = "User already exists";
            public const string USER_NOT_EXIST = "User does not exist";
            public const string AREA_NOT_SUBSCRIPTION = "Selected Area has been not subscribed";
            public const string FILES_NO_FILES_YET = "No files yet";
            public const string FILES_LIMIT_FILES_SIZE = "Total file size should not exceed {0}";
            public const string FILES_SCE_UPLOAD_NOT_SUPPORT_FILE = "Only support files: PDF, Excel(xls, xlsx), Word(doc, docx), Image(jpeg, jpg)";
            public const string FILES_LIMIT_FILE = "Maximum of {0} files.";
            public const string FILES_UPLOAD_FAIL = "Upload {0} fail";
            public const string FILES_UPLOAD_SUCCESSFULLY = "Upload {0} successfully";
            public const string FILES_DELETE_FILES_SUCCESSFULLY = "Delete {0} successfully";
            public const string FILES_DELETE_FILES_FAIL = "Delete {0} fail";
            public const string MESSAGE_PUSH_NOTIFICATION_CREATE = "{0} created your {1} and is now pending for review";
            public const string MESSAGE_PUSH_NOTIFICATION_REVIEW = "{0} reviewed your {1} and is now pending for endorsement";
            public const string MESSAGE_PUSH_NOTIFICATION_UPDATE_REQUIRED = "{0} reviewed your {1} and is now pending for endorsement";
            public const string MESSAGE_PUSH_NOTIFICATION_ENDORSE = "{0} endorsed your {1} and is now pending for approval";
            public const string MESSAGE_PUSH_NOTIFICATION_APPROVE = "{0} approved your {1} and is now pending for acknowledgement";
            public const string MESSAGE_PUSH_NOTIFICATION_ACKNOWLEDGE = "{0} acknowledge your {1} and is now Live";
            public const string MESSAGE_PUSH_NOTIFICATION_TRANSFER = "{0} transfered your {1}";
            public const string MESSAGE_PUSH_NOTIFICATION_TRANSFERROLES = "{0} transfered roles your {1}";
            public const string MESSAGE_PUSH_NOTIFICATION_REJECT = "{0} rejected your {1} and is now require update from you";
            public const string MESSAGE_PUSH_NOTIFICATION_PENDING = "{0} is now pending your {1}";
            public const string MESSAGE_PUSH_NOTIFICATION_MOC_APPROVE = "{0} MOC approved your {1}";
            public const string MESSAGE_PUSH_NOTIFICATION_RA_MOC_CANCELLED = "This MOC has been cancelled";
            public const string SCE_CANCELLED = "This SCE has been cancelled";
            public const string RA_CANCELLED = "This RA has been cancelled";
            public const string SCE_PARENT_NOT_EXITS = "SCE parent has been cancelled or not exist";
            public const string SCE_NOT_EXITS = "SCE has been cancelled or not exist";
            public const string RA_SCE_PARENT_NOT_EXITS = "Risk Assessment parent has been cancelled or not exist";
            public const string SCE_ACCEPT_RA_COPY = "Exiting RA No. <b>{0}</b> information will be copied into new RA request. Are you sure to procced?";
        }

        public static class Action
        {
            public const string SUBMIT = "submit";
            public const string DRAFT = "draft";
            public const string REJECT = "reject";
            public const string APPROVE = "approve";
            public const string UPDATE = "update";
        }

        public static class StatusLogActionKey
        {
            #region SCE

            public const string SCE_SUBMIT = "SCE_SUBMIT";
            public const string SCE_SAVE_DRAFT = "SCE_SAVE_DRAFT";
            public const string SCE_ASSIGN_REVIEW = "SCE_ASSIGN_REVIEW";
            public const string SCE_UPDATE = "SCE_UPDATE";

            public const string SCE_REVIEW_REJECT = "SCE_REVIEW_REJECT";
            public const string SCE_REVIEW_APPROVE = "SCE_REVIEW_APPROVE";
            public const string SCE_REVIEW_ASSIGN_ENDORSER = "SCE_REVIEW_ASSIGN_ENDORSER";
            public const string SCE_REVIEW_ASSIGN_APPROVER = "SCE_REVIEW_ASSIGN_APPROVER";

            public const string SCE_ENDORSE_REJECT = "SCE_ENDORSE_REJECT";
            public const string SCE_ENDORSE_APPROVE = "SCE_ENDORSE_APPROVE";

            public const string SCE_APPROVE_REJECT = "SCE_APPROVE_REJECT";
            public const string SCE_APPROVE_APPROVE = "SCE_APPROVE_APPROVE";

            public const string SCE_ACKNOWLEDGE_APPROVER = "SCE_ACKNOWLEDGE_APPROVER";

            public const string SCE_REAPPROVE = "SCE_REAPPROVE";

            public const string SCE_REACKNOWLEDGE = "SCE_REACKNOWLEDGE";

            public const string SCE_NORMALIZE = "SCE_NORMALIZE";

            public const string SCE_TRANSFER = "SCE_TRANSFER";
            public const string SCE_UPDATE_REVIEWER = "SCE_UPDATE_REVIEWER";
            public const string SCE_TRANSFER_ROLE_APPLICANT = "SCE_TRANSFER_ROLE_APPLICANT";
            public const string SCE_TRANSFER_ROLE_REVIEWER = "SCE_TRANSFER_ROLE_REVIEWER";
            public const string SCE_TRANSFER_ROLE_ENDORSER = "SCE_TRANSFER_ROLE_ENDORSER";
            public const string SCE_TRANSFER_ROLE_APPROVER = "SCE_TRANSFER_ROLE_APPROVER";
            #endregion

            #region RA

            public const string RA_SUBMIT = "RA_SUBMIT";
            public const string RA_UPADTE = "RA_UPADTE";
            public const string RA_SAVE_DRAFT = "RA_SAVE_DRAFT";
            public const string RA_ASSIGN_REVIEW = "RA_ASSIGN_REVIEW";
            public const string RA_ASSIGN_ENDORSE = "RA_ASSIGN_ENDORSE";
            public const string RA_ASSIGN_APPROVE = "RA_ASSIGN_APPROVE";

            public const string RA_REVIEWER_APPROVE = "RA_REVIEWER_APPROVE";
            public const string RA_REVIEWER_REJECT = "RA_REVIEWER_REJECT";

            public const string RA_ENDORSER_APPROVE = "RA_ENDORSER_APPROVE";
            public const string RA_ENDORSER_REJECT = "RA_ENDORSER_REJECT";

            public const string RA_APPROVER_APPROVE = "RA_APPROVER_APPROVE";
            public const string RA_APPROVER_REJECT = "RA_APPROVER_REJECT";

            public const string RA_TRANSFER_REVIEWER = "RA_TRANSFER_REVIEWER";
            public const string RA_TRANSFER_ENDORSER = "RA_TRANSFER_ENDORSER";
            public const string RA_TRANSFER_APPROVER = "RA_TRANSFER_APPROVER";

            public const string RA_MOC_SUMMIT = "RA_MOC_SUMMIT";
            public const string RA_MOC_UPDATE = "RA_MOC_UPDATE";
            public const string RA_MOC_ASSIGN_APPROVER = "RA_MOC_ASSIGN_APPROVER";
            public const string RA_MOC_APPROVE = "RA_MOC_APPROVE";
            public const string RA_MOC_REJECT = "RA_MOC_REJECT";

            #endregion
        }

        public static class Pattern
        {
            public static class DateTime
            {
                public const string DD_MM_YYYY_HH_MM_SS = "{00:ddMMyyyyHHmmss}";
                public const string DD_MM_YYYY_HH_MM_SS_FFF = "{00:ddMMyyyyHHmmssfff}";
            }
            public const string RA = "{0}-RA";
        }

        public static class Page
        {
            public const string RA_FORM = "RA";
            public const string SCE_FORM = "SCE";
        }

        public static class Properties
        {
            public const string UserInfo = "UserInfo";

            public class Ldap
            {
                public const string UserId = "SamAccountName";
                public const string UserName = "name";
                public const string Email = "mail";
                public const string StaffNo = "employeenumber";
                public const string Dept = "department";
                public const string Division = "title";
                public const string Image = "thumbnailphoto";
            }
        }

        public static class AppSetting
        {
            public const string LINK_SITE = "linkSite";
            public const string URL_SINGLE_SIGN_ON = "urlSingleSignOn";
            public const string FOLDER_EMAIL_NOTIFICATION = "folderEmailNotification";
            public const string FOLDER_EMAIL_NOTIFICATION_ERROR = "folderEmailNotificationError";
            public const string LDAP_USER_NAME = "ldap-username";
            public const string LDAP_PASSWORD = "ldap-password";
            public const string LDAP_PATH = "ldap-path";
            //Infomation config use push notification
            public const string FCM_SERVER_APIKEY = "fcmServerApiKey";
            public const string FCM_SENDER_ID = "fcmSenderID";
            public const string FCM_HOST = "fcmHost";
        }

        public static class ConnectionStrings
        {
            public const string CONNECTION_DATABASE = "PPUPIContext";
        }

        public static class Key
        {
            public const string ACCESS_TOKEN = "Access-Token";
            public const string TOKEN = "Token";
            public const string SCE_UPLOAD_SUPPORT_FILE = "pdf;xlsx;xls;doc;docx;jpeg;png;jpg";
        }

        public static class Filter
        {
            public static class UserList
            {
                public static class FilterDefault
                {
                    public const string Field = "UserId";
                }

                public static class SortDefault
                {
                    public const string Field = "CreatedDateTime";
                    public const bool Asc = false;
                }
            }

            public static class SceList
            {
                public static class FilterDefault
                {
                    public const string Field = "Area";
                }

                public static class SortDefault
                {
                    public const string Field = "RequisitionDate";
                    public const bool Asc = false;
                }
            }
        }

        public static class ReferenceType
        {
            public const string Sce = "SCE";
            public const string Ra = "RA";
        }
    }
}