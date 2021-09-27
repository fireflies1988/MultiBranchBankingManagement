CREATE VIEW vw_SubscriberServers
AS
SELECT TENCN = p.description, TENSERVER = s.subscriber_server
FROM sysmergepublications p INNER JOIN sysmergesubscriptions s ON p.pubid = s.pubid
WHERE publisher <> subscriber_server AND subscriber_server <> 'DESKTOP-9OUV00A\MSSQLSERVER3'