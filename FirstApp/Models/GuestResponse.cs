using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{

	public class GuestResponse
	{
		[Required(ErrorMessage = "Podaj imie człowieku ;/")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Podaj email czlowieku"), EmailAddress(ErrorMessage = "To nie adres świnko ;/")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Podaj telefon kolego")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Czy sie zjawisz ziom?")]
		public bool? WillAttend { get; set; }
	}

}
