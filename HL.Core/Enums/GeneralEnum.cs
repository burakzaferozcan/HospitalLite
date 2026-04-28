namespace HL.Core.Enums;

public enum AppointmentStatus
{
    Scheduled = 1, // randevu oluşturuldu
    Checked = 2, // hasta hasta hastaneye geldi
    InExamination = 3, // muayene sürüyor
    LabPending = 4, // tahlil sonucu bekleniyor
    Completed = 5, // muayene bitti
    Cancelled = 6, // iptal edildi

}
