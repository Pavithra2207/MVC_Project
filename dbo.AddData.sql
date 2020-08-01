Create procedure [dbo].[AddData]  
(  
   @Category varchar (50),  
   @Year varchar (50),  
   @Amount varchar (50)  
)  
as  
begin  
   Insert into Details values(@Category,@Year,@Amount)  
End  
