SELECT a.PT_NAME,
       a.PT_NO,
       a.GEND_CD, 
       a.AGE,
       IFNULL(a.TLNO,'NONE') as TLNO
  FROM PATIENT a
 where a.AGE<=12 AND 
       a.GEND_CD='W'
ORDER BY a.AGE DESC, a.PT_NAME;