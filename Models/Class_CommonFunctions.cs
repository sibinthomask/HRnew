namespace HRnew.Models
{
    public class Class_CommonFunctions
    {
        //public List<Class_Gender> getGender()
        //{
        //    var getStatusFn = new List<Class_Gender>
        //    {
        //        new Class_Gender { GenderValue="", GenderText = "----Select Status----"},
        //        new Class_Gender { GenderValue="Male", GenderText = "Male"},
        //        new Class_Gender { GenderValue="Female", GenderText = "Female"}
        //    };
        //    return getStatusFn;
        //}

        //public List<Class_Status> getStatusDetails()
        //{
        //    var getStatusFn = new List<Class_Status>
        //    {
        //        new Class_Status { UsrStatusId=0, UsrStatusText = "----Select Status----"},
        //        new Class_Status { UsrStatusId=1, UsrStatusText = "Active"},
        //        new Class_Status { UsrStatusId=2, UsrStatusText = "Inactive"},
        //        new Class_Status { UsrStatusId=3, UsrStatusText = "Already Processed"},
        //        new Class_Status { UsrStatusId=4, UsrStatusText = "Pending verification"},
        //        new Class_Status { UsrStatusId=5, UsrStatusText = "Certificate issued"},
        //        new Class_Status { UsrStatusId=6, UsrStatusText = "Expired"},
        //        new Class_Status { UsrStatusId=7, UsrStatusText = "Not setup"},
        //        new Class_Status { UsrStatusId=8, UsrStatusText = "Revoked"}
        //    };
        //    return getStatusFn;
        //}

        //public List<Class_Marital_Status> getMaritalStatus()
        //{
        //    var getStatusFn = new List<Class_Marital_Status>
        //    {
        //        new Class_Marital_Status { MaritalStatusId=0, MaritalStatusText = "----Select Marital Status----"},
        //        new Class_Marital_Status { MaritalStatusId=1, MaritalStatusText = "Single"},
        //        new Class_Marital_Status { MaritalStatusId=2, MaritalStatusText = "Married"},
        //        new Class_Marital_Status { MaritalStatusId=3, MaritalStatusText = "Widowed"},
        //        new Class_Marital_Status { MaritalStatusId=4, MaritalStatusText = "Divorced"},
        //        new Class_Marital_Status { MaritalStatusId=5, MaritalStatusText = "Separated"}
        //    };
        //    return getStatusFn;
        //}

        //public List<Class_BloodGroup> getBloodGroup()
        //{
        //    var getBloodGroupFn = new List<Class_BloodGroup>
        //    {
        //        new Class_BloodGroup { BloodGroupId=0, BloodGroupText = "----Select BloodGroup----"},
        //        new Class_BloodGroup { BloodGroupId=1, BloodGroupText = "O positive"},
        //        new Class_BloodGroup { BloodGroupId=2, BloodGroupText = "O negative"},
        //        new Class_BloodGroup { BloodGroupId=3, BloodGroupText = "A positive"},
        //        new Class_BloodGroup { BloodGroupId=4, BloodGroupText = "A negative"},
        //        new Class_BloodGroup { BloodGroupId=5, BloodGroupText = "B positive"},
        //        new Class_BloodGroup { BloodGroupId=6, BloodGroupText = "B negative"},
        //        new Class_BloodGroup { BloodGroupId=7, BloodGroupText = "AB positive"},
        //        new Class_BloodGroup { BloodGroupId=6, BloodGroupText = "AB negative"}
        //    };
        //    return getBloodGroupFn;
        //}

        //public List<Class_CertificateTypes> CertificateTypes()
        //{
        //    var getCertificateTypeFn = new List<Class_CertificateTypes>
        //    {
        //        new Class_CertificateTypes { CertificateTypeId=0, CertificateTypeText = "----Select Certificate----"},
        //        new Class_CertificateTypes { CertificateTypeId=1, CertificateTypeText = "Course completion"},
        //        new Class_CertificateTypes { CertificateTypeId=2, CertificateTypeText = "Experience"}
        //    };
        //    return getCertificateTypeFn;
        //}

        public List<Class_SalaryStatus> getSalaryStatus()
        {
            var getStatusFn = new List<Class_SalaryStatus>
            {
                new Class_SalaryStatus { SalaryStatusId=0, SalaryStatusText = "----Select SalaryStatus----"},
                new Class_SalaryStatus { SalaryStatusId=1, SalaryStatusText = "Salary Paid"},
                new Class_SalaryStatus { SalaryStatusId=2, SalaryStatusText = "Not paid"},
                new Class_SalaryStatus { SalaryStatusId=3, SalaryStatusText = "Professional Tax"},
                new Class_SalaryStatus { SalaryStatusId=4, SalaryStatusText = "Other deductions"},
                new Class_SalaryStatus { SalaryStatusId=5, SalaryStatusText = "Overtime pay"},
                new Class_SalaryStatus { SalaryStatusId=6, SalaryStatusText = "Bonuses"},
                new Class_SalaryStatus { SalaryStatusId=7, SalaryStatusText = "Provident Fund"},
                new Class_SalaryStatus { SalaryStatusId=8, SalaryStatusText = "Labour Welfare Fund"}
            };
            return getStatusFn;
        }

    }
}
