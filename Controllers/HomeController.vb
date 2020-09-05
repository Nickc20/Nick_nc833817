Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Learn about the one and only Nick Capretta."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Please direct all questions about Capretta Industries to the contact points below."

        Return View()
    End Function
End Class
