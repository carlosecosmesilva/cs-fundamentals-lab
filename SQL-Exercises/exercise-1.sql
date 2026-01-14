WITH SalariosRankeados AS (
    SELECT
        d.Nome AS Departamento,
        p.Nome AS Pessoa,
        p.Salario,
        RANK() OVER (
            PARTITION BY p.DeptId
            ORDER BY
                p.Salario DESC
        ) as Ranking
    FROM
        Pessoa p
        INNER JOIN Departamento d ON p.DeptId = d.Id
)
SELECT
    Departamento,
    Pessoa,
    Salario
FROM
    SalariosRankeados
WHERE
    Ranking = 1;