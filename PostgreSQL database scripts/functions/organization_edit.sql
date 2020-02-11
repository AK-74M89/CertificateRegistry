CREATE OR REPLACE FUNCTION public.organization_edit(
	id integer,
	name character varying)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
    
AS $BODY$begin
	update organization
	set name = $2
	where organization.id = $1;
	return $1;
end$BODY$;

ALTER FUNCTION public.organization_edit(integer, character varying)
    OWNER TO postgres;
