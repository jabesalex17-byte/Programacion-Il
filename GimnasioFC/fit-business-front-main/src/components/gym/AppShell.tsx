import { Link, useRouterState } from "@tanstack/react-router";
import { Dumbbell, Users, Medal, Briefcase, CreditCard, LayoutDashboard } from "lucide-react";
import type { ReactNode } from "react";
import { Toaster } from "@/components/ui/sonner";

const nav = [
  { to: "/", label: "Panel", icon: LayoutDashboard },
  { to: "/miembros", label: "Miembros", icon: Users },
  { to: "/coaches", label: "Coaches", icon: Medal },
  { to: "/empleados", label: "Empleados", icon: Briefcase },
  { to: "/suscripciones", label: "Suscripciones", icon: CreditCard },
] as const;

export function AppShell({ children }: { children: ReactNode }) {
  const pathname = useRouterState({ select: (s) => s.location.pathname });

  return (
    <div className="flex min-h-screen bg-background text-foreground">
      <aside className="sticky top-0 hidden h-screen w-60 shrink-0 flex-col border-r border-border bg-sidebar p-4 md:flex">
        <div className="mb-8 flex items-center gap-2 px-2">
          <span className="flex size-9 items-center justify-center rounded-lg bg-primary text-primary-foreground">
            <Dumbbell className="size-5" />
          </span>
          <div className="leading-tight">
            <p className="text-sm font-black tracking-tight uppercase">GimnasioFC</p>
            <p className="text-xs text-muted-foreground">Gestión de gimnasio</p>
          </div>
        </div>
        <nav className="flex flex-1 flex-col gap-1">
          {nav.map((item) => {
            const active = pathname === item.to;
            const Icon = item.icon;
            return (
              <Link
                key={item.to}
                to={item.to}
                className={`flex items-center gap-3 rounded-lg px-3 py-2 text-sm font-medium transition-colors ${
                  active
                    ? "bg-primary text-primary-foreground"
                    : "text-muted-foreground hover:bg-accent hover:text-accent-foreground"
                }`}
              >
                <Icon className="size-4" />
                {item.label}
              </Link>
            );
          })}
        </nav>
      </aside>

      <div className="flex min-w-0 flex-1 flex-col">
        <div className="flex gap-1 overflow-x-auto border-b border-border p-2 md:hidden">
          {nav.map((item) => (
            <Link
              key={item.to}
              to={item.to}
              className={`rounded-md px-3 py-1.5 text-xs font-medium whitespace-nowrap ${
                pathname === item.to
                  ? "bg-primary text-primary-foreground"
                  : "text-muted-foreground"
              }`}
            >
              {item.label}
            </Link>
          ))}
        </div>
        <main className="flex-1 p-6 md:p-10">{children}</main>
      </div>
      <Toaster richColors position="top-right" />
    </div>
  );
}
