CREATE OR REPLACE FUNCTION public.certificate_get_registry (
)
RETURNS TABLE (
  id_certificate integer,
  certificate_name varchar,
  certificate_number varchar,
  certificate_date_begin date,
  certificate_date_end date,
  organization_name varchar
) AS
$body$
DECLARE
  certificates record;
  current_organization_name VARCHAR;
BEGIN
  RETURN QUERY
  select  c.id,
      c.name as certificate_name,
      c.number as certificate_number,
      c.date_begin as certificate_date_begin,
      c.date_end as certificate_date_end,
      o.name as organization_name
  from certificate as c
  join organization as o on c.id_organization = o.id;
END;
$body$
LANGUAGE 'plpgsql'
VOLATILE
CALLED ON NULL INPUT
SECURITY INVOKER
COST 100 ROWS 1000;