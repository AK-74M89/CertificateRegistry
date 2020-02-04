-- FUNCTION: public.organization_can_delete(integer)

-- DROP FUNCTION public.organization_can_delete(integer);

CREATE OR REPLACE FUNCTION public.organization_can_delete(
	organization_id integer)
    RETURNS boolean
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$declare certificate_count integer;
begin
	select count(*) into certificate_count
	from certificate as c
	where c.id_organization = $1;
	
	return certificate_count = 0;
end$BODY$;

ALTER FUNCTION public.organization_can_delete(integer)
    OWNER TO postgres;
