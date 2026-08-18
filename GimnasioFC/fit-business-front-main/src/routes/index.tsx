import { createFileRoute } from "@tanstack/react-router";
import { useQuery } from "@tanstack/react-query";
import { Link } from "@tanstack/react-router";
import { Briefcase, CreditCard, Medal, Users } from "lucide-react";
import { AppShell } from "@/components/gym/AppShell";
import { coachesApi, employeesApi, membersApi, subscriptionsApi } from "@/lib/gym-api";

export const Route = createFileRoute("/")({
  head: () => ({
    meta: [
      { title: "GimnasioFC — Panel de gestión del gimnasio" },
      {
        name: "description",
        content:
          "Panel para administrar miembros, coaches, empleados y suscripciones del gimnasio.",
      },
      { property: "og:title", content: "GimnasioFC — Panel de gestión del gimnasio" },
      {
        property: "og:description",
        content: "Administra miembros, coaches, empleados y suscripciones en un solo lugar.",
      },
    ],
  }),
  component: Dashboard,
});

function StatCard({
  label,
  value,
  loading,
  icon: Icon,
  to,
}: {
  label: string;
  value: number;
  loading: boolean;
  icon: typeof Users;
  to: string;
}) {
  return (
    <Link
      to={to}
      className="group rounded-xl border border-border bg-card p-5 transition-colors hover:border-primary"
    >
      <div className="flex items-center justify-between">
        <span className="text-xs font-semibold uppercase tracking-wide text-muted-foreground">
          {label}
        </span>
        <Icon className="size-4 text-primary" />
      </div>
      <p className="mt-3 text-4xl font-black tabular-nums">{loading ? "—" : value}</p>
    </Link>
  );
}

function Dashboard() {
  const members = useQuery({ queryKey: ["Member"], queryFn: membersApi.list, retry: false });
  const coaches = useQuery({ queryKey: ["Coach"], queryFn: coachesApi.list, retry: false });
  const employees = useQuery({
    queryKey: ["Employee"],
    queryFn: employeesApi.list,
    retry: false,
  });
  const subs = useQuery({
    queryKey: ["Subscription"],
    queryFn: subscriptionsApi.list,
    retry: false,
  });

  const activeSubs = (subs.data ?? []).filter((s) => s.activa).length;

  return (
    <AppShell>
      <div className="space-y-8">
        <header>
          <p className="text-xs font-bold uppercase tracking-[0.2em] text-primary">
            Sistema de gestión
          </p>
          <h1 className="mt-2 text-4xl font-black tracking-tight uppercase">
            Panel del gimnasio
          </h1>
          <p className="mt-2 max-w-xl text-sm text-muted-foreground">
            Administra miembros, coaches, empleados y suscripciones de tu gimnasio.
          </p>
        </header>

        <div className="grid gap-4 sm:grid-cols-2 lg:grid-cols-4">
          <StatCard
            label="Miembros"
            value={members.data?.length ?? 0}
            loading={members.isLoading}
            icon={Users}
            to="/miembros"
          />
          <StatCard
            label="Coaches"
            value={coaches.data?.length ?? 0}
            loading={coaches.isLoading}
            icon={Medal}
            to="/coaches"
          />
          <StatCard
            label="Empleados"
            value={employees.data?.length ?? 0}
            loading={employees.isLoading}
            icon={Briefcase}
            to="/empleados"
          />
          <StatCard
            label="Suscripciones activas"
            value={activeSubs}
            loading={subs.isLoading}
            icon={CreditCard}
            to="/suscripciones"
          />
        </div>

      </div>
    </AppShell>
  );
}
