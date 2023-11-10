# APILibrary
Restful API/Yael Frank

פיתוח מערכת לניהול ספרייה
ישויות:
•	ספרים
•	משתמשים
•	הלוואות ספרים

מיפוי Routes  ספרים: 
יטפל בכל הפעולות הקשורות לספרים בספרייה. 
הוא יכלול פונקציות כמו 
•	שליפת ספרים מן הרשימה                         https://library/api/books
•	הוספת ספרים חדשים לספרייה,                  https://library/api/books   
•	עדכון פרטי הספר                       https://library/api/books/{bookId} 
•	ומחיקת ספרים.                          https://library/api/books/{bookId} 


מיפוי Routes חברים: 
ינהל את חברי הספרייה או המשתמשים. 
הוא יטפל בפונקציונליות כמו 
•	קבלת רשימת החברים בספריה                https://library/api/members
•	רישום חברים חדשים,                             https://library/api/members
•	עדכון פרטי חברים              https://library/api/members/{memberId}
•	והסרת חברים. https://library/api/members/{memberId}                         


מיפוי Routes  השאלות ספרים:
יטפל בניהול הלוואות ספרים. 
הוא יכלול פונקציות כמו 
•	קבלת נתוני השאלת ספרים https://library/api/loans                                      
•	הוספת השאלות ספרים למשתמשים,                https://library/api/loans
•	עדכון השאלות                                 https://library/api/loans/{loanId} 
•	החזרת ספרים -הסרתם מן היומן         https://library/api/loans/{loanId}
