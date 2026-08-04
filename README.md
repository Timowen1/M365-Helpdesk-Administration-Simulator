# M365 Helpdesk Administration Simulator

A C# WinForms training simulator built to practice common IT support workflows in a Microsoft 365 / Windows 11 style environment.

## Purpose

I built this project to practice hands-on helpdesk and administrator workflows without needing access to a live Microsoft 365 tenant. The simulator models users, groups, devices, mailbox troubleshooting, device health checks, audit logging, and ticket-based scenarios.

## Features

- Create, enable, disable, soft-delete, and restore users
- Reset user passwords with audit logging
- Create groups and manage group membership
- Create, assign, retire, reactivate, and mark devices lost/non-compliant
- Simulate mailbox issues such as missing mail license, mailbox full, forwarding, and blocked mailbox
- Simulate Windows device health issues such as BitLocker, Defender, Windows Update, disk space, and check-in status
- JSON-powered ticket scenarios
- Auto-checking ticket progress
- Audit log for administrative actions

## Technologies used

- C#
- WinForms
- Newtonsoft.Json
- Local in-memory fake data store
- JSON scenario loading

## Why did I build this Project?

This project was built as an interview preparation tool for IT Support Specialist workflows involving user, group, device, email, and Windows administrative troubleshooting.
