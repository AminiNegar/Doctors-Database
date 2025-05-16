<---3--->
select p.FirstName,p.LastName from Patient p join Doctor d
on p.PrimaryDoctor_SSN=d.SSN
and d.FirstName='علي' and d.LastName='ايراني'


<---4--->
select M.TradeName AS 'نام تجاري دارو' , count(DISTINCT(P.Id)) AS 'تعداد نسخه ها' ,
	   SUM(PM.NumOfUnits) AS 'تعداد کل واحدهاي تجويز شده' 
	   FROM Medicine M JOIN Prescription_Medicine ON M.TradeName = PM.TradeName JOIN
	   Prescription P ON PM.Prescription_id = P.Id
	   Group By M.TradeName ;

<---5--->
SELECT p.FirstName , p.LastName
	From Patient p JOIN Prescription pr ON p.SSN = pr.Patient_SSN 
	GROUP By p.SSN , p.FirstName, p.LastName 
	HAVING COUNT(pr.Id) = (
	SELECT TOP (1) COUNT (Id) 
	FROM Prescription 
	GROUP BY Patient_SSN 
	ORDER BY COUNT(Id) DESC
	)

<---6--->
select P.FirstName as 'نام' , count(distinct Pr.Id) as 'تعداد نسخه ها' from Patient P join Prescription Pr on P.SSN = Pr.Patient_SSN 
group by P.LastName , P.FirstName
having count(distinct Pr.ID) > 5
order by P.LastName , P.FirstName

<---7--->
Select * from Medicine
where UnitPrice= (select Max(UnitPrice) from Medicine) or
      UnitPrice= (select Min(UnitPrice) from Medicine)
order by UnitPrice desc;

<---8--->
select d.SSN as 'شناسه پزشک' , 
d.FirstName + ' ' + d.LastName as 'نام پزشک' , 
m.TradeName as 'نام دارو' , 
m.UnitPrice as 'قيمت واحد دارو '
from Doctor d join Prescription on d.SSN = p.Doctor_SSN 
join Prescription_Medicine pm on p.Id = pm.Prescription_id
join Medicine m on pm.TradeName = m.TradeName
where(m.UnitPrice = (select max(UnitPrice)from Medicine))

<---9--->
Declare @avgPrice int =( select  avg(m.UnitPrice) from Medicine m);

select DISTINCT d.SSN,d.FirstName,d.LastName from 
((Doctor d join Prescription p 
on d.SSN=p.Doctor_SSN) join Prescription_Medicine pm 
on p.Id=pm.Prescription_id) join Medicine m 
on m.TradeName=pm.TradeName
where m.UnitPrice>=@avgPrice;


<---10--->
select P.FirstName + ' ' + P.LastName as 'نام بيمار' , 
M.TradeName as 'نام دارو' , count(distinct Pr.Doctor_SSN) as 'تعداد پزشک ها'
From Patient P join Prescription Pr on P.SSN = Pr.Patient_SSN
Join Medicine M on PM.TradeName = M.TradeName 
group by P.FirstName , P.LastName , M.TradeName
having count(distinct Pr.Doctor_SSN) >= 2

<---11--->
SELECT P.SSN AS PatientSSN, P.FirstName AS PatientFirstName,
P.LastName AS PatientLastName, D.SSN AS DoctorSSN, 
D.FirstName AS DoctorFirstName, D.LastName AS DoctorLastName, 
YEAR(Pr.Date) AS VisitYear, COUNT(*) AS VisitCount
FROM Patient P
JOIN Prescription Pr ON P.SSN = Pr.Patient_SSN
JOIN Doctor D ON Pr.Doctor_SSN = D.SSN
GROUP BY P.SSN, P.FirstName, P.LastName, D.SSN, D.FirstName, D.LastName, YEAR(Pr.Date)
HAVING COUNT(*) > 1;

<---12--->
Select year(P.Date) as 'سال' , count(distinct P.Id) as 'تعداد نسخه ها'
From Prescription P join Prescription_Medicine PM on P.Id  PM.Prescription_id join Medicine M on PM.TradeName = M.TradeName
Where (M.TradeName = 'آسپرين' and PM.NumOfUnits = 1)
Group by year(P.Date)


<---13--->
SELECT P.PrescriptionYear, P.TotalPrescriptions,  
      (A.AspirinPrescriptions * 100.0) / P.TotalPrescriptions AS AspirinPrescriptionPercentage
FROM (
    SELECT YEAR(P.Date) AS PrescriptionYear, COUNT(P.Id) AS TotalPrescriptions
    FROM Prescription P
    GROUP BY YEAR(P.Date)
) P
 JOIN (
    SELECT YEAR(P.Date) AS PrescriptionYear, 
	COUNT(P.Id) AS AspirinPrescriptions
    FROM Prescription P
    JOIN Prescription_Medicine PM ON P.Id = PM.Prescription_id
    WHERE PM.TradeName = 'آسپرين' AND PM.NumOfUnits = 1
    GROUP BY YEAR(P.Date)
) A ON P.PrescriptionYear = A.PrescriptionYear
ORDER BY P.PrescriptionYear;


<---14--->
select top 1(year(Date)/10)* 10 as year , count(Id) as count_prescriptions from Prescription
group by (year(Date)/10) * 10 
order by count_prescriptions desc

<---15--->
DECLARE @maxDistinctMedicine INT;

SELECT TOP(1) @maxDistinctMedicine = COUNT(DISTINCT TradeName)
FROM Prescription_Medicine
GROUP BY Prescription_id
ORDER BY COUNT(DISTINCT TradeName) DESC;

SELECT Prescription_id, COUNT(DISTINCT TradeName) AS DistinctCount
FROM Prescription_Medicine
GROUP BY Prescription_id
HAVING COUNT(DISTINCT TradeName) = @maxDistinctMedicine;

<---16--->
Select top 2* from Prescription P1 , Prescription P2 where P1.Id < P2.Id and exists(
Select 1
From Prescription_Medicine PM1 , Prescription_Medicine PM2
Where P1.Id = PM1.Prescription_id
And P2.Id = PM2.Prescription_id
And PM1.TradeName = PM2.TradeName
)
Order by P1.Id , P2.Id

<---17--->

UPDATE Prescription_Medicine
SET TradeName = 'دیازپام'
WHERE Prescription_id IN (
    SELECT pm.Prescription_id
    FROM Prescription p join Prescription_Medicine pm on p.Id=pm.Prescription_id
    WHERE pm.TradeName = 'کلونازپام' 
        AND EXISTS (
            SELECT 1
            FROM Prescription p2 join Prescription_Medicine pm2 on p2.Id=pm2.Prescription_id
            WHERE p2.Patient_SSN = p.Patient_SSN
                AND pm2.TradeName = 'آسپرین'
        )
);

<---18--->
Create function get_doctors(@medicine_name  nvarchar(255))
Returns nvarchar(max)
As
Begin
Declare @DOctorList nvarchar(max)
Select @DoctorList = @DoctorList + ‘,’ + D.FirstName + ‘ ’ + D.LastName from Doctor D join Prescription P on D.SSN = P.Doctor_SSN  join Prescription_Medicine PM on P.Id = PM.Prescription_id where PM.TradeName = @medicine_name
If len(@DoctorList) > 0 
Set @DoctorList = substring(@DoctorList , 3, len(@DoctorList) )
Return @DoctorList
end

<---19--->
CREATE FUNCTION CalculateAverageAge(@MedicineName NVARCHAR(100))
RETURNS FLOAT
AS
BEGIN
    DECLARE @AverageAge FLOAT;
	Declare @a INT=1402;
    SELECT @AverageAge = AVG(@a-YEAR(Pat.DOB))
    FROM Prescription P
    JOIN Prescription_Medicine PM ON P.Id = PM.Prescription_id
    JOIN Patient Pat ON P.Patient_SSN = Pat.SSN
    WHERE PM.TradeName = @MedicineName;

    RETURN @AverageAge;
END;

CREATE FUNCTION AverageAge(@MedicineName NVARCHAR(100))
RETURNS FLOAT
AS
BEGIN
    DECLARE @AverageAge FLOAT;
    DECLARE @a INT = 1402;

    SELECT @AverageAge = AVG(@a - YEAR(DistinctPatients.DOB))
    FROM (
        SELECT DISTINCT Pat.SSN, Pat.DOB
        FROM Prescription P
        JOIN Prescription_Medicine PM ON P.Id = PM.Prescription_id
        JOIN Patient Pat ON P.Patient_SSN = Pat.SSN
        WHERE PM.TradeName = @MedicineName
    ) AS DistinctPatients;

    RETURN @AverageAge;
END;

